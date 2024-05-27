namespace Application.ViewModel.Request
{
    public class WeaponRequest: BaseRequest
    {
        public string Name { get; set; }
        public int Mod { get; set; }
        public string Attr { get; set; }
    }
}
