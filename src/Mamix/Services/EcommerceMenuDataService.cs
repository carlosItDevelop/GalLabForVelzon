public class EcommerceMenuDataService
{
    private List<MainMenuItems> MenuData = new List<MainMenuItems>()
    {
        new MainMenuItems (
            path: "/ecommerce-landing",
            type: "link",
            title: "Home",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "/ecommerce-aboutus",
            type: "link",
            title: "About",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            type: "sub",
            title: "Shop",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/ecommerce-search",
                    type: "link",
                    title: "Shop",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/ecommerce-details",
                    type: "link",
                    title: "Product Details",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/ecommerce-customer-wishlist",
                    type: "link",
                    title: "Wishlist",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/ecommerce-customer-cart",
                    type: "link",
                    title: "Cart",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/ecommerce-customer-coupons",
                    type: "link",
                    title: "Coupons",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/ecommerce-customer-checkout",
                    type: "link",
                    title: "Checkout",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems (
            path: "/ecommerce-vendor",
            type: "link",
            title: "Vendors",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            type: "sub",
            title: "Pages",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/ecommerce-customer",
                    type: "link",
                    title: "My Account",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/ecommerce-customer-settings",
                    type: "link",
                    title: "Settings",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/ecommerce-terms-conditions",
                    type: "link",
                    title: "Terms Of Conditions",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/ecommerce-privacy-policies",
                    type: "link",
                    title: "Privacy Policy",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/ecommerce-customer-compare",
                    type: "link",
                    title: "Compare Products",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        new MainMenuItems (
            path: "/ecommerce-contactus",
            type: "link",
            title: "Contact",
            selected: false,
            active: false,
            dirChange: false
        ),
    };

    public List<MainMenuItems> GetMenuData()
   {
        return MenuData;
    }
}
