﻿namespace Application.ViewModel.Request
{
    public class AttributeRequest : BaseRequest
    {
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }
    }
}
