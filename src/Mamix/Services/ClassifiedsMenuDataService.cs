public class ClassifiedsMenuDataService
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
            title: "Categories",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "",
            type: "link",
            title: "All Ads",
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
                    title: "FAQ",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "",
                    type: "link",
                    title: "Services",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "",
                    type: "link",
                    title: "Add Details",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "",
                    type: "link",
                    title: "Add Post",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "",
                    type: "link",
                    title: "404",
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
            type: "sub",
            title: "Blog",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "",
                    type: "link",
                    title: "Blog",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "",
                    type: "link",
                    title: "Blog Details",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "",
                    type: "link",
                    title: "Blog Post",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
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
