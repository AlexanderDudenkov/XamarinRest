using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ServerApp.util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ServerApp
{
    class MainViewModel : INotifyPropertyChanged
    {
        public bool IsRunning { get; set; }
        public bool IsVisible { get; set; }
        public ObservableCollection<Model> List { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand LoadDataCommand { protected set; get; }

        public MainViewModel()
        {
            //this.LoadDataCommand = new Command(LoadData);
            IsVisible = true;
            IsRunning = true;
            List = new ObservableCollection<Model>();
            LoadData();
            IsRunning = false;
            IsVisible = false;
        }

        private async void LoadData()
        {
            try
            {
                HttpClient client = new HttpClient();
               
                client.BaseAddress = new Uri(Constants.getInstance().url);
                var response = await client.GetAsync(client.BaseAddress);
                response.EnsureSuccessStatusCode();

                string content = await response.Content.ReadAsStringAsync();
                JArray a = JArray.Parse(content);

                for (int i = 0; i < a.Count; i++)
                {
                    var o = JObject.Parse(a[i].ToString());
                    var str = o.SelectToken(@"$.urls");
                    var photosUrl = JsonConvert.DeserializeObject<PhotosUrl>(str.ToString());
                    Model model = new Model();
                    model.PhotosUrl = photosUrl;
                    List.Add(model);
                }
                
            }
            catch (Exception ex)
            { System.Console.WriteLine($"DEBUG {ex.Message}"); }
        }


    }


}
