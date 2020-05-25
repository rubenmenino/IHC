using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT
{
    public class AddNewRecipe : ObservableObject, IDataErrorInfo
    {
        public string Error { get { return null;  } }
        
        private string _recipe;

       

        public string Recipe
        {
            get { return _recipe;  }
            set
            {
                OnPropertyChanged(ref _recipe, value);
            }
        }
        public string this[string recipe]
        {
            get
            {
                string result = null;

                switch (recipe)
                {
                    case "Recipe":
                        if (string.IsNullOrWhiteSpace(Recipe))
                        {
                            result = "Field cannot be empty";
                        }
                        break;
                }

             

                return result;
            }
        }

        
    }
}
