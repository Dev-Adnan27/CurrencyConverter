using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace CurrencyConverter
{
    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            InitializeComponent();
            PopulateCurrencyCodesFrom();
            PopulateCurrencyCodesTo();

        }
        private async Task<decimal?> GetCurrencyConversion(string fromCurrency, string toCurrency, decimal amount)
        {
            string apiUrl = $"https://currency-exchange.p.rapidapi.com/exchange?from={fromCurrency}&to={toCurrency}&q={amount}";
            string apiKey = "e13b606d9fmshec5c3f24bbed7c4p18b470jsn53af55c1d39e";
            string apiHost = "currency-exchange.p.rapidapi.com";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-RapidAPI-Key", apiKey);
                client.DefaultRequestHeaders.Add("X-RapidAPI-Host", apiHost);

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    return ExtractNewAmountFromJson(result);
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error: {error}");
                    return null;
                }
            }
        }
        private decimal? ExtractNewAmountFromJson(string json)
        {
            try
            {
                JToken token = JToken.Parse(json);
                if (token.Type == JTokenType.Float || token.Type == JTokenType.Integer)
                {
                    decimal newAmount = (decimal)token;
                    return newAmount;
                }
                else
                {
                    MessageBox.Show("Unexpected JSON format or missing data.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error parsing JSON: {ex.Message}");
                return null;
            }
        }
        private void PopulateCurrencyCodesFrom()
        {
            string[] currencyCodes = {
                 "PKR","USD", "EUR", "JPY", "GBP", "AUD", "CAD", "CHF", "CNY",  "SEK",
                 "KRW", "SGD", "NOK", "MXN", "INR", "RUB", "ZAR", "TRY", "BRL", "HKD",
                 "DKK", "AED", "ARS", "TWD", "THB", "PLN", "IDR", "ILS", "PHP", "CLP",
                 "CZK", "EGP", "MYR", "HUF", "COP", "SAR", "VND", "RON", "KES", "NGN",
                 "UAH", "BDT", "IQD", "MAD", "UZS", "QAR", "HRK", "OMR", "SGD", "NZD",
                 "DZD", "KZT", "TND", "UGX", "BDT", "LKR", "MOP", "NPR", "SYP", "UYU",
                 "BYN", "KHR", "GEL", "JOD", "NAD", "RSD", "BHD", "BND", "ERN", "ETB",
                 "FJD", "GHS", "ISK", "JMD", "KPW", "LBP", "LSL", "LYD", "MKD", "MUR",
        };
            FromConvertCurrency.DataSource = currencyCodes;
        }     
        private void PopulateCurrencyCodesTo()
        {
            string[] currencyCodes = {
                 "PKR","USD", "EUR", "JPY", "GBP", "AUD", "CAD", "CHF", "CNY",  "SEK",
                 "KRW", "SGD", "NOK", "MXN", "INR", "RUB", "ZAR", "TRY", "BRL", "HKD",
                 "DKK", "AED", "ARS", "TWD", "THB", "PLN", "IDR", "ILS", "PHP", "CLP",
                 "CZK", "EGP", "MYR", "HUF", "COP", "SAR", "VND", "RON", "KES", "NGN",
                 "UAH", "BDT", "IQD", "MAD", "UZS", "QAR", "HRK", "OMR", "SGD", "NZD",
                 "DZD", "KZT", "TND", "UGX", "BDT", "LKR", "MOP", "NPR", "SYP", "UYU",
                 "BYN", "KHR", "GEL", "JOD", "NAD", "RSD", "BHD", "BND", "ERN", "ETB",
                 "FJD", "GHS", "ISK", "JMD", "KPW", "LBP", "LSL", "LYD", "MKD", "MUR",
        };
            ToConvertCurrency.DataSource = currencyCodes;
        }

        private async void ConvertBtn_Click(object sender, EventArgs e)
        {
            string selectedFromCurrency = FromConvertCurrency.SelectedItem?.ToString();
            string selectedToCurrency = ToConvertCurrency.SelectedItem?.ToString();
            decimal selectedAmount = Convert.ToDecimal(FromMoney.Text);
            decimal? newAmount = await GetCurrencyConversion(selectedFromCurrency,selectedToCurrency,selectedAmount);
            if (newAmount != null)
            {
                ToMoney.Text = newAmount.ToString();
            }
        }

        private void ShuffleBtn_Click(object sender, EventArgs e)
        {
            string xyx = ToMoney.Text;
            ToMoney.Text = FromMoney.Text;
            FromMoney.Text = xyx;
            string yxy = FromConvertCurrency.SelectedItem?.ToString();
            FromConvertCurrency.SelectedItem = ToConvertCurrency.SelectedItem?.ToString();
            ToConvertCurrency.SelectedItem = yxy;
        }
    }
}