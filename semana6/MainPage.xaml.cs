using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace semana6
{
    public partial class MainPage : ContentPage
    {
        private const string Url = "192.168.56.1/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<semana6.Ws.Datos> _post;
        public MainPage()
        {
            InitializeComponent();
          
        }
     

        private void btnGet_Clicked(object sender, EventArgs e)
        {
            var content = await client.GetStringAsync(Url);
            List<semana6.Ws.Datos> post = JsonConvert.DeserializeObject<List<semana6.Ws.Datos>>(content);
            _post = new ObservableCollection<semana6.Ws.Datos>(post);


        }
    }
}

