namespace Application.ViewModel.Request
{
    public class KnightRequest : BaseRequest
    {
        public string Name { get; set; }
        public string NickName { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public List<WeaponRequest> Weapons { get; set; }
        public AttributeRequest Attributes { get; set; }

        public string KeyAttribute { get; set; }
    }
}
