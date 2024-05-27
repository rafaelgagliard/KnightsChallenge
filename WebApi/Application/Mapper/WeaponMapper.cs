using Application.ViewModel.Request;
using Domain.Entities;

namespace Application.Mapper
{
    public static class WeaponMapper
    {
        public static Weapon RequestToWeapon(this WeaponRequest weaponRequest) =>
            new Weapon()
            {
                Attr = weaponRequest.Attr,
                Equipped = false,
                Mod = weaponRequest.Mod,
                Name = weaponRequest.Name
            };

    }
}