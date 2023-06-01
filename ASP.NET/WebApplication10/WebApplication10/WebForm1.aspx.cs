using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();
            switch (DropDownList1.Text) 
            {
                case "India":
                    DropDownList2.Items.Add("Maharashtra");
                    DropDownList2.Items.Add("Himachal Pradesh");
                    DropDownList2.Items.Add("Haryana");
                    DropDownList2.Items.Add("Kerala");
                 break;
                case "Brazil":
                    DropDownList2.Items.Add("Alagoas");
                    DropDownList2.Items.Add("Amapa");
                    DropDownList2.Items.Add("Amazonas");
                    DropDownList2.Items.Add("Rio de Janeiro");
                    break;
                case "Germany":
                    DropDownList2.Items.Add("Hamburg");
                    DropDownList2.Items.Add("Mecklenburg-Vorpommern");
                    DropDownList2.Items.Add("Bremen");
                    DropDownList2.Items.Add("Thüringen ");
                    break;
                case "France":
                    DropDownList2.Items.Add("Brittany");
                    DropDownList2.Items.Add("Corsica");
                    DropDownList2.Items.Add("Grand Est.");
                    DropDownList2.Items.Add("Paris Region ");
                    break;
                case "Nepal":
                    DropDownList2.Items.Add("Jumla");
                    DropDownList2.Items.Add("Jajarkot");
                    DropDownList2.Items.Add("Malneta");
                    DropDownList2.Items.Add("House of Tulsipur");
                    break;
            }

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList3.Items.Clear();
            switch (DropDownList2.Text)
            {
                case "Maharashtra":
                    DropDownList3.Items.Add("Nagpur");
                    DropDownList3.Items.Add("Pune");
                    DropDownList3.Items.Add("Mumbai");
                    DropDownList3.Items.Add("Buldhana");
                    break;
                case "Himachal Pradesh":
                    DropDownList3.Items.Add("Shimla");
                    DropDownList3.Items.Add("Dharamsala");
                    DropDownList3.Items.Add("Solan");
                    DropDownList3.Items.Add("Palampur ");
                    break;
                case "Haryana":
                    DropDownList3.Items.Add("Panipat");
                    DropDownList3.Items.Add("Sonepat");
                    DropDownList3.Items.Add("Gurugram");
                    DropDownList3.Items.Add("Kurukshetra ");
                    break;
                case "Kerala":
                    DropDownList3.Items.Add("Thiruvananthapuram");
                    DropDownList3.Items.Add("Kochi");
                    DropDownList3.Items.Add("Kozhikode");
                    DropDownList3.Items.Add("Kollam  ");
                    break;
                case "Alagoas":
                    DropDownList3.Items.Add("Maceió ");
                    DropDownList3.Items.Add("Arapiraca ");
                    DropDownList3.Items.Add("Delmiro Gouveia");
                    DropDownList3.Items.Add("Porto Calvo");
                    break;
                    
                case "Amapa":
                    DropDownList3.Items.Add("Amapá ");
                    DropDownList3.Items.Add("Macapá ");
                    DropDownList3.Items.Add("Porto Grande");
                    DropDownList3.Items.Add("Pedra Branca do Amapari");
                    break;
                case "Amazonas":
                    DropDownList3.Items.Add("Barcelos");
                    DropDownList3.Items.Add("Eirunepe");
                    DropDownList3.Items.Add("Itacoatiara");
                    DropDownList3.Items.Add("Manacapuru");
                    break;
                case "Rio de Janeiro":
                    DropDownList3.Items.Add("Copacabana ");
                    DropDownList3.Items.Add("Ipanema ");
                    DropDownList3.Items.Add("Armação dos Búzios");
                    DropDownList3.Items.Add("Niterói ");
                    break;
                case "Hamburg":
                    DropDownList3.Items.Add("Alsterdorf ");
                    DropDownList3.Items.Add("Hamburg");
                    DropDownList3.Items.Add("Hamburg-Altstadt");
                    DropDownList3.Items.Add("St. Georg");
                    break;
               case "Mecklenburg-Vorpommern":
                    DropDownList3.Items.Add("Neubrandenburg  ");
                    DropDownList3.Items.Add("Rostock ");
                    DropDownList3.Items.Add("Anklam ");
                    DropDownList3.Items.Add("Neustrelitz");
                    break;
                case "Bremen":
                    DropDownList3.Items.Add("Barcelos");
                    DropDownList3.Items.Add("Eirunepe");
                    DropDownList3.Items.Add("Itacoatiara");
                    DropDownList3.Items.Add("Manacapuru");
                    break;
                case "Thüringen":
                    DropDownList3.Items.Add("Copacabana ");
                    DropDownList3.Items.Add("Ipanema ");
                    DropDownList3.Items.Add("Armação dos Búzios");
                    DropDownList3.Items.Add("Niterói ");
                    break;
            }
        }
    }
}