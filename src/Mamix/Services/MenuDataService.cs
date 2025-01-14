using GeneralLabSolutions.Domain.Entities;
using static mamix.Pages.Cadastros.TabelaPedidos;

public class MenuDataService
{
    private List<MainMenuItems> MenuData = new List<MainMenuItems>()
    {
        new MainMenuItems(
            menuTitle: "MAIN"
        ),
        new MainMenuItems(
            type: "sub",
            title: "Dashboards",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M216,115.54V208a8,8,0,0,1-8,8H160a8,8,0,0,1-8-8V160a8,8,0,0,0-8-8H112a8,8,0,0,0-8,8v48a8,8,0,0,1-8,8H48a8,8,0,0,1-8-8V115.54a8,8,0,0,1,2.62-5.92l80-75.54a8,8,0,0,1,10.77,0l80,75.54A8,8,0,0,1,216,115.54Z' opacity='0.2'></path><path d='M218.83,103.77l-80-75.48a1.14,1.14,0,0,1-.11-.11,16,16,0,0,0-21.53,0l-.11.11L37.17,103.77A16,16,0,0,0,32,115.55V208a16,16,0,0,0,16,16H96a16,16,0,0,0,16-16V160h32v48a16,16,0,0,0,16,16h48a16,16,0,0,0,16-16V115.55A16,16,0,0,0,218.83,103.77ZM208,208H160V160a16,16,0,0,0-16-16H112a16,16,0,0,0-16,16v48H48V115.55l.11-.1L128,40l79.9,75.43.11.1Z'></path></svg>",
            badgeValue: "",
            badgeClass: "",
            
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/index",
                    type: "link",
                    title: "Sales",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index2",
                    type: "link",
                    title: "Analytics",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index3",
                    type: "link",
                    title: "Ecommerce",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index4",
                    type: "link",
                    title: "CRM",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index5",
                    type: "link",
                    title: "Crypto",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index6",
                    type: "link",
                    title: "NFT",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index7",
                    type: "link",
                    title: "Projects",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index8",
                    type: "link",
                    title: "Jobs",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index9",
                    type: "link",
                    title: "HRM",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index10",
                    type: "link",
                    title: "Courses",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index11",
                    type: "link",
                    title: "Stocks",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index12",
                    type: "link",
                    title: "Medical",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index13",
                    type: "link",
                    title: "POS System",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index14",
                    type: "link",
                    title: "Podcast",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index15",
                    type: "link",
                    title: "School",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index16",
                    type: "link",
                    title: "Social Media",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),




        new MainMenuItems(
            menuTitle: "CADASTRO"
        ),
        new MainMenuItems(
            type: "sub",
            title: "Cadastros",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M216,115.54V208a8,8,0,0,1-8,8H160a8,8,0,0,1-8-8V160a8,8,0,0,0-8-8H112a8,8,0,0,0-8,8v48a8,8,0,0,1-8,8H48a8,8,0,0,1-8-8V115.54a8,8,0,0,1,2.62-5.92l80-75.54a8,8,0,0,1,10.77,0l80,75.54A8,8,0,0,1,216,115.54Z' opacity='0.2'></path><path d='M218.83,103.77l-80-75.48a1.14,1.14,0,0,1-.11-.11,16,16,0,0,0-21.53,0l-.11.11L37.17,103.77A16,16,0,0,0,32,115.55V208a16,16,0,0,0,16,16H96a16,16,0,0,0,16-16V160h32v48a16,16,0,0,0,16,16h48a16,16,0,0,0,16-16V115.55A16,16,0,0,0,218.83,103.77ZM208,208H160V160a16,16,0,0,0-16-16H112a16,16,0,0,0-16,16v48H48V115.55l.11-.1L128,40l79.9,75.43.11.1Z'></path></svg>",
            badgeValue: "",
            badgeClass: "",

            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {

                new MainMenuItems (
                    path: "/pedidomanager",
                    type: "link",
                    title: "Pedidos",
                    selected: false,
                    active: false,
                    dirChange: false
                ),

                new MainMenuItems (
                    path: "/clientemanager",
                    type: "link",
                    title: "Clientes",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/produtomanager",
                    type: "link",
                    title: "Produtos",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                    new MainMenuItems (
                    path: "/vendedormanager",
                    type: "link",
                    title: "Vendedores",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                    new MainMenuItems (
                    path: "/categoriaproduto",
                    type: "link",
                    title: "Categoria",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                    new MainMenuItems (
                    path: "/tabela-pedidos",
                    type: "link",
                    title: "Pedido Fake",
                    selected: false,
                    active: false,
                    dirChange: false
                )

                

            }
        ),




        new MainMenuItems(
            menuTitle: "Web Apps"
        ),
        new MainMenuItems(
            type: "sub",
            title: "Apps",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M112,56v48a8,8,0,0,1-8,8H56a8,8,0,0,1-8-8V56a8,8,0,0,1,8-8h48A8,8,0,0,1,112,56Zm88-8H152a8,8,0,0,0-8,8v48a8,8,0,0,0,8,8h48a8,8,0,0,0,8-8V56A8,8,0,0,0,200,48Zm-96,96H56a8,8,0,0,0-8,8v48a8,8,0,0,0,8,8h48a8,8,0,0,0,8-8V152A8,8,0,0,0,104,144Zm96,0H152a8,8,0,0,0-8,8v48a8,8,0,0,0,8,8h48a8,8,0,0,0,8-8V152A8,8,0,0,0,200,144Z' opacity='0.2'></path><path d='M200,136H152a16,16,0,0,0-16,16v48a16,16,0,0,0,16,16h48a16,16,0,0,0,16-16V152A16,16,0,0,0,200,136Zm0,64H152V152h48v48ZM104,40H56A16,16,0,0,0,40,56v48a16,16,0,0,0,16,16h48a16,16,0,0,0,16-16V56A16,16,0,0,0,104,40Zm0,64H56V56h48v48Zm96-64H152a16,16,0,0,0-16,16v48a16,16,0,0,0,16,16h48a16,16,0,0,0,16-16V56A16,16,0,0,0,200,40Zm0,64H152V56h48v48Zm-96,32H56a16,16,0,0,0-16,16v48a16,16,0,0,0,16,16h48a16,16,0,0,0,16-16V152A16,16,0,0,0,104,136Zm0,64H56V152h48v48Z'></path></svg>",
            badgeValue: "Hot",
            badgeClass: "bg-success shadow-success ms-2",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Ecommerce",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "",
                            type: "sub",
                            title: "Admin",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "/ecommerce-admin-addcustomer",
                                    type: "link",
                                    title: "Add Customer",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-addproduct",
                                    type: "link",
                                    title: "Add Product",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-addvendor",
                                    type: "link",
                                    title: "Add Vendor",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-blog",
                                    type: "link",
                                    title: "Blog",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-customerdetails",
                                    type: "link",
                                    title: "Customer Details",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-customers",
                                    type: "link",
                                    title: "Customers List",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-faq",
                                    type: "link",
                                    title: "Faq's",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-newsletter",
                                    type: "link",
                                    title: "News Letter",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-orders",
                                    type: "link",
                                    title: "Orders",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-ordersdetails",
                                    type: "link",
                                    title: "Order Details",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-paymentgateways",
                                    type: "link",
                                    title: "Payment Gateways",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-products",
                                    type: "link",
                                    title: "Products",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-refundrequests",
                                    type: "link",
                                    title: "Refund requests",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-reports",
                                    type: "link",
                                    title: "Reports",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-testimonials",
                                    type: "link",
                                    title: "Testimonials",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-vendordetails",
                                    type: "link",
                                    title: "Vendor Details",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-admin-vendors",
                                    type: "link",
                                    title: "Vendors List",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-app-settings",
                                    type: "link",
                                    title: "App Settings",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                            }
                        ),
                        new MainMenuItems (
                            path: "",
                            type: "sub",
                            title: "Customer",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "/ecommerce-customer",
                                    type: "external",
                                    title: "Customer",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-customer-address",
                                    type: "external",
                                    title: "Address",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-landing",
                                    type: "external",
                                    title: "landing Page",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-search",
                                    type: "external",
                                    title: "Shop",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-details",
                                    type: "external",
                                    title: "Product Details",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-customer-cart",
                                    type: "external",
                                    title: "Cart",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-customer-checkout",
                                    type: "external",
                                    title: "Checkout",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-customer-compare",
                                    type: "external",
                                    title: "Compare Products",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-customer-coupons",
                                    type: "external",
                                    title: "Coupons",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-customer-ordertracking",
                                    type: "external",
                                    title: "Order Tracking",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-customer-refunds",
                                    type: "external",
                                    title: "Refunds",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-customer-settings",
                                    type: "external",
                                    title: "Settings",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-customer-wishlist",
                                    type: "external",
                                    title: "Wishlist",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                            }
                        ),
                        new MainMenuItems (
                            path: "",
                            type: "sub",
                            title: "Vendor",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "/ecommerce-vendor",
                                    type: "external",
                                    title: "Vendor",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-vendor-addproduct",
                                    type: "external",
                                    title: "Add Product",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-vendor-invoicedetails",
                                    type: "external",
                                    title: "Invoice Detail",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-vendor-invoices",
                                    type: "external",
                                    title: "Invoices",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-vendor-orders",
                                    type: "external",
                                    title: "Orders",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-vendor-packages",
                                    type: "external",
                                    title: "Packages",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-vendor-public-profile",
                                    type: "external",
                                    title: "Profile",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-vendor-refunds",
                                    type: "external",
                                    title: "Refund Requests",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "/ecommerce-vendor-settings",
                                    type: "external",
                                    title: "Settings",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                            }
                        ),
                    }
                ),

                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Classifieds",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/classifieds-admin",
                            type: "link",
                            title: "Admin",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/classifieds-details",
                            type: "external",
                            title: "Classified Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/classifieds-landing",
                            type: "external",
                            title: "Landing",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/classifieds-search",
                            type: "external",
                            title: "Search",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/classifieds-user-profile",
                            type: "link",
                            title: "User Profile",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),

                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Domain",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/domain-admin",
                            type: "link",
                            title: "Admin",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/domain-single-landing",
                            type: "external",
                            title: "Single Landing",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/domain-details",
                            type: "external",
                            title: "Domain Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/domain-landing",
                            type: "external",
                            title: "Landing",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Market Place",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/marketplace-admin",
                            type: "link",
                            title: "Admin",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/marketplace-details",
                            type: "external",
                            title: "Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/marketplace-landing",
                            type: "external",
                            title: "Landing",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/marketplace-search",
                            type: "external",
                            title: "Search",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/marketplace-user",
                            type: "external",
                            title: "User",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/marketplace-user-public-profile",
                            type: "external",
                            title: "User Profile",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/marketplace-vendor",
                            type: "external",
                            title: "Vendor",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),

                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Real Estate",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/realestate-admin",
                            type: "link",
                            title: "Admin",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/realestate-details",
                            type: "external",
                            title: "Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/realestate-landing",
                            type: "external",
                            title: "Landing",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/realestate-search",
                            type: "external",
                            title: "Search",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/realestate-user",
                            type: "external",
                            title: "User",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/realestate-user-public-profile",
                            type: "external",
                            title: "User Profile",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/realestate-vendor",
                            type: "external",
                            title: "Vendor",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Calendars",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/full-calendar",
                            type: "link",
                            title: "Full Calendar",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/blazor-calendar",
                            type: "link",
                            title: "Blazor Calendar",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/gallery",
                    type: "link",
                    title: "Gallery",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/sweet-alerts",
                    type: "link",
                    title: "Sweet Alerts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Projects",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/projects-list",
                            type: "link",
                            title: "Projects List",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/projects-overview",
                            type: "link",
                            title: "Project Overview",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/projects-create",
                            type: "link",
                            title: "Create Project",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Task",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/task-kanban-board",
                            type: "link",
                            title: "Kanban Board",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/task-list-view",
                            type: "link",
                            title: "List View",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/task-details",
                            type: "link",
                            title: "Task Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Jobs",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/job-details",
                            type: "link",
                            title: "Job Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-company-search",
                            type: "link",
                            title: "Search Company",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-search",
                            type: "link",
                            title: "Search Jobs",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-post",
                            type: "link",
                            title: "Job Post",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-list",
                            type: "link",
                            title: "Job List",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-candidate-search",
                            type: "link",
                            title: "Search Candidate",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-candidate-details",
                            type: "link",
                            title: "Candidate Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "NFT",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/nft-marketplace",
                            type: "link",
                            title: "Market Place",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/nft-details",
                            type: "link",
                            title: "NFT Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/nft-create",
                            type: "link",
                            title: "Create NFT",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/nft-wallet-integration",
                            type: "link",
                            title: "Wallet Integration",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/nft-live-auction",
                            type: "link",
                            title: "Live Auction",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "CRM",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/crm-contacts",
                            type: "link",
                            title: "Contacts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crm-companies",
                            type: "link",
                            title: "Companies",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crm-deals",
                            type: "link",
                            title: "Deals",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crm-leads",
                            type: "link",
                            title: "Leads",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Crypto",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/crypto-transactions",
                            type: "link",
                            title: "Transactions",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crypto-currency-exchange",
                            type: "link",
                            title: "Currency Exchange",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crypto-buy-sell",
                            type: "link",
                            title: "Buy & Sell",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crypto-marketcap",
                            type: "link",
                            title: "Marketcap",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crypto-wallet",
                            type: "link",
                            title: "Wallet",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
            }
        ),

        new MainMenuItems (
            type: "sub",
            title: "Nested Menu",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M224,80l-96,56L32,80l96-56Z' opacity='0.2'></path><path d='M230.91,172A8,8,0,0,1,228,182.91l-96,56a8,8,0,0,1-8.06,0l-96-56A8,8,0,0,1,36,169.09l92,53.65,92-53.65A8,8,0,0,1,230.91,172ZM220,121.09l-92,53.65L36,121.09A8,8,0,0,0,28,134.91l96,56a8,8,0,0,0,8.06,0l96-56A8,8,0,1,0,220,121.09ZM24,80a8,8,0,0,1,4-6.91l96-56a8,8,0,0,1,8.06,0l96,56a8,8,0,0,1,0,13.82l-96,56a8,8,0,0,1-8.06,0l-96-56A8,8,0,0,1,24,80Zm23.88,0L128,126.74,208.12,80,128,33.26Z'></path></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "",
                    type: "empty",
                    title: "Nested-1",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Nested-2",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "",
                            type: "empty",
                            title: "Nested-2-1",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            type: "sub",
                            title: "Nested-2-2",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "",
                                    type: "empty",
                                    title: "Nested-2-2-1",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "",
                                    type: "empty",
                                    title: "Nested-2-2-2",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                )
                            }
                        )
                    }
                )
            }
        ),

        new MainMenuItems(
            menuTitle: "PAGES"
        ),

        new MainMenuItems (
            type: "sub",
            title: "Authentication",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M216,96V208a8,8,0,0,1-8,8H48a8,8,0,0,1-8-8V96a8,8,0,0,1,8-8H208A8,8,0,0,1,216,96Z' opacity='0.2'></path><path d='M208,80H176V56a48,48,0,0,0-96,0V80H48A16,16,0,0,0,32,96V208a16,16,0,0,0,16,16H208a16,16,0,0,0,16-16V96A16,16,0,0,0,208,80ZM96,56a32,32,0,0,1,64,0V80H96ZM208,208H48V96H208V208Zm-68-56a12,12,0,1,1-12-12A12,12,0,0,1,140,152Z'></path></svg>",
            badgeValue: "8",
            badgeClass: "bg-primary shadow-primary ms-2",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems ( 
                    path: "/comingsoon",
                    type: "link",
                    title: "Coming Soon",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Create Password",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/createpassword-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/createpassword-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Lock Screen",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/lockscreen-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/lockscreen-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Reset Password",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/resetpassword-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/resetpassword-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Sign Up",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/signup-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/signup-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Sign In",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/signin-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/signin-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Two Step Verification",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/twostep-verification-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/twostep-verification-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    path: "/under-maintenance",
                    type: "link",
                    title: "Under Maintenance",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),

        new MainMenuItems (
            type: "sub",
            title: "Error",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M224,128a96,96,0,1,1-96-96A96,96,0,0,1,224,128Z' opacity='0.2'></path><path d='M128,24A104,104,0,1,0,232,128,104.11,104.11,0,0,0,128,24Zm0,192a88,88,0,1,1,88-88A88.1,88.1,0,0,1,128,216Zm-8-80V80a8,8,0,0,1,16,0v56a8,8,0,0,1-16,0Zm20,36a12,12,0,1,1-12-12A12,12,0,0,1,140,172Z'></path></svg>",
            badgeValue: "3",
            badgeClass: "bg-secondary shadow-secondary ms-2",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/error401",
                    type: "link",
                    title: "401 - Error",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/error404",
                    type: "link",
                    title: "404 - Error",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/error500",
                    type: "link",
                    title: "500 - Error",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),

        new MainMenuItems(
            type: "sub",
            title: "Pages",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M224,56V200a8,8,0,0,1-8,8H40a8,8,0,0,1-8-8V56a8,8,0,0,1,8-8H216A8,8,0,0,1,224,56Z' opacity='0.2'></path><path d='M216,40H40A16,16,0,0,0,24,56V200a16,16,0,0,0,16,16H216a16,16,0,0,0,16-16V56A16,16,0,0,0,216,40Zm0,160H40V56H216V200ZM184,96a8,8,0,0,1-8,8H80a8,8,0,0,1,0-16h96A8,8,0,0,1,184,96Zm0,32a8,8,0,0,1-8,8H80a8,8,0,0,1,0-16h96A8,8,0,0,1,184,128Zm0,32a8,8,0,0,1-8,8H80a8,8,0,0,1,0-16h96A8,8,0,0,1,184,160Z'></path></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    type: "sub",
                    title: "Blog",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/blog",
                            type: "link",
                            title: "Blog",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/blog-details",
                            type: "link",
                            title: "Blog Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/blog-create",
                            type: "link",
                            title: "Create Blog",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/chat",
                    type: "link",
                    title: "Chat",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/counter",
                    type: "link",
                    title: "Counter",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Email",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/mail",
                            type: "link",
                            title: "Mail App",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/mail-settings",
                            type: "link",
                            title: "Mail Settings",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/empty-page",
                    type: "link",
                    title: "Empty",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/faqs",
                    type: "link",
                    title: "FAQ's",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/filemanager",
                    type: "link",
                    title: "File Manager",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Invoice",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/invoice-create",
                            type: "link",
                            title: "Create Invoice",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/invoice-details",
                            type: "link",
                            title: "Invoice Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/invoice-list",
                            type: "link",
                            title: "Invoice List",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/pricing",
                    type: "link",
                    title: "Pricing",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/profile",
                    type: "link",
                    title: "Profile",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/profile-settings",
                    type: "link",
                    title: "Profile Settings",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/reviews",
                    type: "link",
                    title: "Reviews",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/search-results",
                    type: "link",
                    title: "Search",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/teams",
                    type: "link",
                    title: "Teams",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/terms-conditions",
                    type: "link",
                    title: "Terms & Conditions",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/timeline",
                    type: "link",
                    title: "Timeline",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/todo-list",
                    type: "link",
                    title: "To Do List",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        
        new MainMenuItems (
            menuTitle: "GENERAL"
        ),
        new MainMenuItems (
            type: "sub",
            title: "Forms",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M216,48H40a8,8,0,0,0-8,8V216l32-16,32,16,32-16,32,16,32-16,32,16V56A8,8,0,0,0,216,48ZM112,160H64V96h48Z' opacity='0.2'></path><path d='M216,40H40A16,16,0,0,0,24,56V216a8,8,0,0,0,11.58,7.15L64,208.94l28.42,14.21a8,8,0,0,0,7.16,0L128,208.94l28.42,14.21a8,8,0,0,0,7.16,0L192,208.94l28.42,14.21A8,8,0,0,0,232,216V56A16,16,0,0,0,216,40Zm0,163.06-20.42-10.22a8,8,0,0,0-7.16,0L160,207.06l-28.42-14.22a8,8,0,0,0-7.16,0L96,207.06,67.58,192.84a8,8,0,0,0-7.16,0L40,203.06V56H216ZM136,112a8,8,0,0,1,8-8h48a8,8,0,0,1,0,16H144A8,8,0,0,1,136,112Zm0,32a8,8,0,0,1,8-8h48a8,8,0,0,1,0,16H144A8,8,0,0,1,136,144ZM64,168h48a8,8,0,0,0,8-8V96a8,8,0,0,0-8-8H64a8,8,0,0,0-8,8v64A8,8,0,0,0,64,168Zm8-64h32v48H72Z'></path></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/form-advanced",
                    type: "link",
                    title: "Form Advanced",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Form Elements",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/form-inputs",
                            type: "link",
                            title: "Inputs",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-check-radios",
                            type: "link",
                            title: "Checks & Radios",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-input-groups",
                            type: "link",
                            title: "Input Groups",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-select",
                            type: "link",
                            title: "Form Select",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-range",
                            type: "link",
                            title: "Range Slider",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-input-masks",
                            type: "link",
                            title: "Input Masks",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-file-uploads",
                            type: "link",
                            title: "File Uploads",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-datetime-pickers",
                            type: "link",
                            title: "Date,Time Picker",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-color-pickers",
                            type: "link",
                            title: "Color Pickers",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Form Wizards",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/form-wizards",
                            type: "link",
                            title: "JS",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/blazor-form-wizards",
                            type: "link",
                            title: "Blazor",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/floating-labels",
                    type: "link",
                    title: "Floating Labels",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/form-layouts",
                    type: "link",
                    title: "Form Layouts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/quill-editor",
                    type: "link",
                    title: "Quill Editor",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/form-validations",
                    type: "link",
                    title: "Validations",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/form-select2",
                    type: "link",
                    title: "Select2",
                    selected: false,
                    active: false,
                    dirChange: false
                )
            }
        ),
        
        new MainMenuItems (
            type: "sub",
            title: "Ui Elements",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M216,96v96a8,8,0,0,1-8,8H48a8,8,0,0,1-8-8V96Z' opacity='0.2'></path><path d='M224,48H32A16,16,0,0,0,16,64V88a16,16,0,0,0,16,16v88a16,16,0,0,0,16,16H208a16,16,0,0,0,16-16V104a16,16,0,0,0,16-16V64A16,16,0,0,0,224,48ZM208,192H48V104H208ZM224,88H32V64H224V88ZM96,136a8,8,0,0,1,8-8h48a8,8,0,0,1,0,16H104A8,8,0,0,1,96,136Z'></path></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/alerts",
                    type: "link",
                    title: "Alerts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/badges",
                    type: "link",
                    title: "Badges",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/breadcrumbs",
                    type: "link",
                    title: "Breadcrumbs",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/buttons",
                    type: "link",
                    title: "Buttons",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/buttongroups",
                    type: "link",
                    title: "Button Groups",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/cards",
                    type: "link",
                    title: "Cards",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/dropdowns",
                    type: "link",
                    title: "Dropdowns",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/images-figures",
                    type: "link",
                    title: "Images & Figures",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/links-interactions",
                    type: "link",
                    title: "Links & Interactions",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/listgroups",
                    type: "link",
                    title: "List Groups",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/navs-tabs",
                    type: "link",
                    title: "Navs & Tabs",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/object-fit",
                    type: "link",
                    title: "Object Fit",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/paginations",
                    type: "link",
                    title: "Paginations",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/popovers",
                    type: "link",
                    title: "Popovers",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/progress",
                    type: "link",
                    title: "Progress",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/spinners",
                    type: "link",
                    title: "Spinners",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/toasts",
                    type: "link",
                    title: "Toasts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/tooltips",
                    type: "link",
                    title: "Tooltips",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/typography",
                    type: "link",
                    title: "Typography",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        
        new MainMenuItems (
            type: "sub",
            title: "Advanced Ui",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M58.89,154.89l42.22,42.22-50.63,18.4a7.79,7.79,0,0,1-10-10Zm138.82-4.72L105.83,58.29A7.79,7.79,0,0,0,93,61.14l-14.9,41,75.82,75.82,41-14.9A7.79,7.79,0,0,0,197.71,150.17Z' opacity='0.2'></path><path d='M111.49,52.63a15.8,15.8,0,0,0-26,5.77L33,202.78A15.83,15.83,0,0,0,47.76,224a16,16,0,0,0,5.46-1l144.37-52.5a15.8,15.8,0,0,0,5.78-26Zm-8.33,135.21-35-35,13.16-36.21,58.05,58.05Zm-55,20,14-38.41,24.45,24.45ZM156,168.64,87.36,100l13-35.87,91.43,91.43ZM160,72a37.8,37.8,0,0,1,3.84-15.58C169.14,45.83,179.14,40,192,40c6.7,0,11-2.29,13.65-7.21A22,22,0,0,0,208,23.94,8,8,0,0,1,224,24c0,12.86-8.52,32-32,32-6.7,0-11,2.29-13.65,7.21A22,22,0,0,0,176,72.06,8,8,0,0,1,160,72ZM136,40V16a8,8,0,0,1,16,0V40a8,8,0,0,1-16,0Zm101.66,82.34a8,8,0,1,1-11.32,11.31l-16-16a8,8,0,0,1,11.32-11.32Zm4.87-42.75-24,8a8,8,0,0,1-5.06-15.18l24-8a8,8,0,0,1,5.06,15.18Z'></path></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/accordions-collapse",
                    type: "link",
                    title: "Accordion & Collapse",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/carousel",
                    type: "link",
                    title: "Carousel",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/draggable-cards",
                    type: "link",
                    title: "Draggable Cards",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/media-player",
                    type: "link",
                    title: "Media Player",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/modals-closes",
                    type: "link",
                    title: "Modals & Closes",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/navbarS",
                    type: "link",
                    title: "Navbars",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/offcanvas",
                    type: "link",
                    title: "Offcanvas",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/placeholders",
                    type: "link",
                    title: "Placeholders",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/ratings",
                    type: "link",
                    title: "Ratings",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/ribbons",
                    type: "link",
                    title: "Ribbons",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/slick-carousel",
                    type: "link",
                    title: "Slick Carousel",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/sortable-list",
                    type: "link",
                    title: "Sortable JS",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/tour",
                    type: "link",
                    title: "Tour",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/treeview",
                    type: "link",
                    title: "Treeview",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),

        new MainMenuItems (
            type: "sub",
            title: "Utilities",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M176,96a48,48,0,1,1-48-48A48,48,0,0,1,176,96Z' opacity='0.2'></path><path d='M216,96A88,88,0,1,0,72,163.83V240a8,8,0,0,0,11.58,7.16L128,225l44.43,22.21A8.07,8.07,0,0,0,176,248a8,8,0,0,0,8-8V163.83A87.85,87.85,0,0,0,216,96ZM56,96a72,72,0,1,1,72,72A72.08,72.08,0,0,1,56,96ZM168,227.06l-36.43-18.21a8,8,0,0,0-7.16,0L88,227.06V174.37a87.89,87.89,0,0,0,80,0ZM128,152A56,56,0,1,0,72,96,56.06,56.06,0,0,0,128,152Zm0-96A40,40,0,1,1,88,96,40,40,0,0,1,128,56Z'></path></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/avatars",
                    type: "link",
                    title: "Avatars",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/borders",
                    type: "link",
                    title: "Borders",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/breakpoints",
                    type: "link",
                    title: "Breakpoints",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/colors",
                    type: "link",
                    title: "Colors",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/columns",
                    type: "link",
                    title: "Columns",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/css-grid",
                    type: "link",
                    title: "CSS Grid",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/flex",
                    type: "link",
                    title: "Flex",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/gutters",
                    type: "link",
                    title: "Gutters",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/helpers",
                    type: "link",
                    title: "Helpers",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/positions",
                    type: "link",
                    title: "Positions",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/more",
                    type: "link",
                    title: "Additional Content",
                    selected: false,
                    active: false,
                    dirChange: false
                )
            }
        ),

        new MainMenuItems (
            path: "/widgets",
            type: "link",
            title: "Widgets",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M208,128v72a8,8,0,0,1-8,8H56a8,8,0,0,1-8-8V128Z' opacity='0.2'></path><path d='M216,72H180.92c.39-.33.79-.65,1.17-1A29.53,29.53,0,0,0,192,49.57,32.62,32.62,0,0,0,158.44,16,29.53,29.53,0,0,0,137,25.91a54.94,54.94,0,0,0-9,14.48,54.94,54.94,0,0,0-9-14.48A29.53,29.53,0,0,0,97.56,16,32.62,32.62,0,0,0,64,49.57,29.53,29.53,0,0,0,73.91,71c.38.33.78.65,1.17,1H40A16,16,0,0,0,24,88v32a16,16,0,0,0,16,16v64a16,16,0,0,0,16,16H200a16,16,0,0,0,16-16V136a16,16,0,0,0,16-16V88A16,16,0,0,0,216,72ZM149,36.51a13.69,13.69,0,0,1,10-4.5h.49A16.62,16.62,0,0,1,176,49.08a13.69,13.69,0,0,1-4.5,10c-9.49,8.4-25.24,11.36-35,12.4C137.7,60.89,141,45.5,149,36.51Zm-64.09.36A16.63,16.63,0,0,1,96.59,32h.49a13.69,13.69,0,0,1,10,4.5c8.39,9.48,11.35,25.2,12.39,34.92-9.72-1-25.44-4-34.92-12.39a13.69,13.69,0,0,1-4.5-10A16.6,16.6,0,0,1,84.87,36.87ZM40,88h80v32H40Zm16,48h64v64H56Zm144,64H136V136h64Zm16-80H136V88h80v32Z'></path></svg>",
            selected: false,
            active: false,
            dirChange: false
        ),
        
        new MainMenuItems (
            menuTitle: "MAPS & ICONS"
        ),
        new MainMenuItems (
            type: "sub",
            title: "Maps",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M128,32a96,96,0,1,0,96,96A96,96,0,0,0,128,32Zm16,112L80,176l32-64,64-32Z' opacity='0.2'></path><path d='M128,24A104,104,0,1,0,232,128,104.11,104.11,0,0,0,128,24Zm0,192a88,88,0,1,1,88-88A88.1,88.1,0,0,1,128,216ZM172.42,72.84l-64,32a8.05,8.05,0,0,0-3.58,3.58l-32,64A8,8,0,0,0,80,184a8.1,8.1,0,0,0,3.58-.84l64-32a8.05,8.05,0,0,0,3.58-3.58l32-64a8,8,0,0,0-10.74-10.74ZM138,138,97.89,158.11,118,118l40.15-20.07Z'></path></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/vector-maps",
                    type: "link",
                    title: "Vector Maps",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/leaflet-maps",
                    type: "link",
                    title: "Leaflet Maps",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/google-maps",
                    type: "link",
                    title: "Google Maps",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),

        new MainMenuItems (
            path: "/icons",
            type: "link",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M224,96v16a32,32,0,0,1-64,0V96H96v16a32,32,0,0,1-64,0V96L46.34,45.8A8,8,0,0,1,54,40H202a8,8,0,0,1,7.69,5.8Z' opacity='0.2'></path><path d='M232,96a7.89,7.89,0,0,0-.3-2.2L217.35,43.6A16.07,16.07,0,0,0,202,32H54A16.07,16.07,0,0,0,38.65,43.6L24.31,93.8A7.89,7.89,0,0,0,24,96v16a40,40,0,0,0,16,32v64a16,16,0,0,0,16,16H200a16,16,0,0,0,16-16V144a40,40,0,0,0,16-32ZM54,48H202l11.42,40H42.61Zm50,56h48v8a24,24,0,0,1-48,0Zm-16,0v8a24,24,0,0,1-48,0v-8ZM200,208H56V151.2a40.57,40.57,0,0,0,8,.8,40,40,0,0,0,32-16,40,40,0,0,0,64,0,40,40,0,0,0,32,16,40.57,40.57,0,0,0,8-.8Zm-8-72a24,24,0,0,1-24-24v-8h48v8A24,24,0,0,1,192,136Z'></path></svg>",
            title: "Icons",
            selected: false,
            active: false,
            dirChange: false
        ),

        new MainMenuItems (
            menuTitle: "CHARTS & TABLES"
        ),

        new MainMenuItems (
            type: "sub",
            title: "Charts",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M208,40V208H152V40Z' opacity='0.2'></path><path d='M224,200h-8V40a8,8,0,0,0-8-8H152a8,8,0,0,0-8,8V80H96a8,8,0,0,0-8,8v40H48a8,8,0,0,0-8,8v64H32a8,8,0,0,0,0,16H224a8,8,0,0,0,0-16ZM160,48h40V200H160ZM104,96h40V200H104ZM56,144H88v56H56Z'></path></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    type: "sub",
                    title: "Apex Charts",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/apex-line-charts",
                            type: "link",
                            title: "Line Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-area-charts",
                            type: "link",
                            title: "Area Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-column-charts",
                            type: "link",
                            title: "Column Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-bar-charts",
                            type: "link",
                            title: "Bar Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-mixed-charts",
                            type: "link",
                            title: "Mixed Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-rangearea-charts",
                            type: "link",
                            title: "Range Area Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-timeline-charts",
                            type: "link",
                            title: "Timeline Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-funnel-charts",
                            type: "link",
                            title: "Funnel Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-candlestick-charts",
                            type: "link",
                            title: "Candle Stick Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-boxplot-charts",
                            type: "link",
                            title: "Boxplot Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-bubble-charts",
                            type: "link",
                            title: "Bubble Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-scatter-charts",
                            type: "link",
                            title: "Scatter Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/Apex-heatmap-charts",
                            type: "link",
                            title: "Heatmap Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-treemap-charts",
                            type: "link",
                            title: "Treemap Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-pie-charts",
                            type: "link",
                            title: "Pie Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-radialbar-charts",
                            type: "link",
                            title: "Radialbar Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-radar-charts",
                            type: "link",
                            title: "Radar Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-polararea-charts",
                            type: "link",
                            title: "Polararea Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/chartjs-charts",
                    type: "link",
                    title: "Chartjs",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        
        new MainMenuItems (
            type: "sub",
            title: "Tables",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='side-menu__icon' width='32' height='32' viewBox='0 0 256 256'><path d='M88,104v96H32V104Z' opacity='0.2'></path><path d='M224,48H32a8,8,0,0,0-8,8V192a16,16,0,0,0,16,16H216a16,16,0,0,0,16-16V56A8,8,0,0,0,224,48ZM40,112H80v32H40Zm56,0H216v32H96ZM216,64V96H40V64ZM40,160H80v32H40Zm176,32H96V160H216v32Z'></path></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/tables",
                    type: "link",
                    title: "Tables",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/grid-tables",
                    type: "link",
                    title: "Grid JS Tables",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/data-tables",
                    type: "link",
                    title: "Data Tables",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        
    };

    public List<MainMenuItems> GetMenuData()
   {
        return MenuData;
    }
}
