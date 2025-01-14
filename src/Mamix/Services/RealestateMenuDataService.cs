public class RealestateMenuDataService
{
    private List<MainMenuItems> MenuData = new List<MainMenuItems>()
    {
        new MainMenuItems (
            path: "",
            type: "link",
            title: "Home",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "",
            type: "link",
            title: "Properties",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "",
            type: "link",
            title: "Buy",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "",
            type: "link",
            title: "Rent",
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
                    path: "",
                    type: "link",
                    title: "Abous Us",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "",
                    type: "link",
                    title: "Terms & Conditions",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "",
                    type: "link",
                    title: "Privacy Policy",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Level-2",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "",
                            type: "empty",
                            title: "Level-2-1",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            type: "sub",
                            title: "Level-2-2",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "",
                                    type: "empty",
                                    title: "Level-2-2-1",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "",
                                    type: "empty",
                                    title: "Level-2-2-2",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                            }
                        ),
                    }
                ),
            }
        ),
        new MainMenuItems (
            path: "",
            type: "link",
            title: "Agents",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "",
            type: "link",
            title: "Contact Us",
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
