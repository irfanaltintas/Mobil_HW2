using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnadoluCeng.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Courses : ContentPage
	{
        public System.Collections.ObjectModel.ObservableCollection<Course> CourseList { get; set; }
        public Courses ()
		{
			InitializeComponent ();
            LoadData();
            CourseListView.ItemsSource = CourseList;
		}
        private void LoadData()
        {
            CourseList = new System.Collections.ObjectModel.ObservableCollection<Course>()
            {
               new Course(){Name= "BIL519 - İleri Algoritma Analizi" },
               new Course(){Name= "BIL551 - İleri Veri Tabanı Yönetim Sistemleri"  },
               new Course(){Name= "BIL561 - Bulanık Sinir Ağları"   },
               new Course(){Name= "BIL567 - Öneri Sistemlerine Giriş"   },
               new Course(){Name= "BIM101 - Bilgisayar Programlama I" },
               new Course(){Name= "BIM203 - Mantık Tasarımı" },
               new Course(){Name= "BIM207 - Bilgisayar Programlama III" },
               new Course(){Name= "BIM209 - Yazılım Tasarlama ve Geliştirme Prensipleri" },
               new Course(){Name= "BIM213 - Veri Yapıları ve Algoritmalar" },
               new Course(){Name= "BIM302 - Bilgisayar Ağları" },
               new Course(){Name= "BIM303 - Mikrobilgisayarlar" },
               new Course(){Name= "BIM305 - Bilgisayar Organizasyonu" },
               new Course(){Name= "BIM306 - İşletim Sistemleri" },
               new Course(){Name= "BIM308 - Web Sunucu Programlama" },
               new Course(){Name= "BIM309 - Yapay Us" },
               new Course(){Name= "BIM314 - Hesaplama Kuramı" },
               new Course(){Name= "BIM405 - Proje Yönetimi" },
               new Course(){Name= "BIM423 - Yazılım Mühendisliği" },
               new Course(){Name= "BIM437 - Bilgisayar Mühendisliği Tasarımları" },
               new Course(){Name= "BIM439 - Veritabanı Yönetim Sistemleri Uygulamaları" },
               new Course(){Name= "BIM451 - MVC ile Web Sunucu Programlama" },
               new Course(){Name= "BIM466 - Bulanık Mantık" },
               new Course(){Name= "BIM478 - Yönetim Bilişim Sistemleri" },
               new Course(){Name= "BIM485 - Bilgisayar Bilimlerinde Araştırma I - L (Alper Bilge)" },
               new Course(){Name= "BIM488 - Örüntü Tanımaya Giriş" },
               new Course(){Name= "BIM490 - Bilgi Erişim Sistemleri" },
               new Course(){Name= "BIM492 - Tasarım Örüntüleri" },
               new Course(){Name= "BIM493 - Mobil Programlama I" },
               new Course(){Name= "İST252 - Olasılık ve İstatistik" },
               new Course(){Name= "MAT249 - Lineer Cebir ve Diferansiyel Denklemler" },
               new Course(){Name= "MAT806 - Matematik II" }
            };
        }
        public class Course
        {
            public string Name { get; set; }  
        }
    }
}