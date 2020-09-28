using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleApplication1
{
    class PrimaryTasks
    {
        public string getDealerData()
        {
            return @"[{'fName':'John',
                    'lName':'Smith'
                    },
                    {'fName':'Amit',
                    'lName':'Sai'
                    }]";
        }
        public void DisplayDealerData()
        {
            var jsonData = getDealerData();
            List<CustomerModel> myDetails = JsonConvert.DeserializeObject<List<CustomerModel>>(jsonData);
            foreach (var v in myDetails)
            {
                Console.WriteLine("First Name: "+v.fName + "    Last Name: "+ v.lName);
            }
        }
    }
    public class CustomerModel
    {
        public string fName { get; set; }
        public string lName { get; set; }
    }
}
