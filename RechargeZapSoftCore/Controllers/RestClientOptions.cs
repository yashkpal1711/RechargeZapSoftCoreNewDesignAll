namespace RechargeZapSoftCore.Controllers
{
    internal class RestClientOptions
    {
        private string v;

        public RestClientOptions(string v)
        {
            this.v = v;
        }

        public int MaxTimeout { get; set; }
    }
}