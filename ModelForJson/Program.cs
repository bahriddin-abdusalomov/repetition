

using System.Drawing;
using System.Text.Json;
using Newtonsoft.Json;

using (HttpClient client = new HttpClient())
{
    string BASE_URL = "https://nbu.uz/en/exchange-rates/json/";
    HttpResponseMessage response = await client.GetAsync(BASE_URL);

    string respon = await response.Content.ReadAsStringAsync();
    //Console.WriteLine(respon);

    //double necha  = Convert.ToDouble(Console.ReadLine()); 

    Console.Write("Valyutadan: ");  
    string Valyutadan = Console.ReadLine();
    Console.Write("Valyutaga: ");
    string Valyutaga =  Console.ReadLine();

    Console.Write("Summani kiriting: ");
    double summa = Convert.ToDouble(Console.ReadLine());


    List<Valyuta> nbuList = JsonConvert.DeserializeObject<List<Valyuta>>(respon);

    foreach (Valyuta nbu in nbuList)
    {

        //if (nbu.Code.Equals("USD"))
        //{
        //    double dollor =  Convert.ToDouble(nbu.Cb_price) * necha;
        //    Console.WriteLine($"{necha} dollor {dollor} so'm");

        //    double som = necha / Convert.ToDouble(nbu.Cb_price);
        //    Console.WriteLine($"{necha} so'm {som} dollor");
        //}
    }


}




public class Valyuta
{
    public string Title { get; set; }
    public string Code { get; set; }
    public string? Cb_price { get; set; }
    public double? Nbu_buy_price { get; set; }
    public double? Nbu_cell_price { get; set; }
    public string? Date { get; set; }
}
