using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GorillaTest.Model
{
    public class StudentModel
    {
        public int Id 
        { 
            get; 
            set; 
        }

        public string Name 
        { 
            get; 
            set; 
        }

        public string Detail
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public async static Task<ObservableCollection<StudentModel>> GetAllStudents()
        {
      
            using (HttpClient client = new HttpClient())
            {

                var uri = new Uri("http://7dd91533.ngrok.io/api/values");

                HttpResponseMessage response = await client.GetAsync(uri).ConfigureAwait(false);
                string ans = await response.Content.ReadAsStringAsync();
                var lstStudents = JsonConvert.DeserializeObject<ObservableCollection<StudentModel>>(ans);
                return lstStudents;
            }

          
        }

        public async static Task<bool> AddStudent(StudentModel studentModel)
        {
           
            using (HttpClient client = new HttpClient())
            {
                var uri = new Uri("http://7dd91533.ngrok.io/api/values");

                var json = JsonConvert.SerializeObject(studentModel);

                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(uri, content).ConfigureAwait(false);
                string ans = await response.Content.ReadAsStringAsync();

                //bool respuesta = JsonConvert.DeserializeObject<bool>(ans);

                return true;
            }
            
        }


    }
}
