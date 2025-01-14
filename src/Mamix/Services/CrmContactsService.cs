//  Crm Contacts Data Start 
public class CrmContactsService
{
    private List<CrmContact> CrmContactsLists = new List<CrmContact>()
    {
        new CrmContact { 
            ContactImg = "../assets/images/faces/4.jpg", 
            ContactName = "Emily", 
            ContactDetails = "Jul,24 2024 - 4:45PM", 
            ContactId = "258",       
            Email="Emily2981@gmail.com", 
            Phone = "1678-28993-223",
            Company="Spruko Technologies", 
            CompanyImg = "../assets/images/company-logos/1.png", 
            LeadSource = "Social Media", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "New Lead",statusColor="primary-transparent"},
                new TagItem { status = "Prospect",statusColor="primary-transparent"},
            }
        },
        new CrmContact { 
            ContactImg = "../assets/images/faces/12.jpg", 
            ContactName = "James", 
            ContactDetails = "Jul,15 2024 - 11:45AM", 
            ContactId = "335",       
            Email="James289@gmail.com", 
            Phone = "8122-2342-4453",
            Company="Spice Infotech", 
            CompanyImg = "../assets/images/company-logos/3.png", 
            LeadSource = "Direct mail", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "Customer",statusColor="primary-transparent"},
                new TagItem { status = "Hot Lead",statusColor="danger-transparent"},
            }
        },
        new CrmContact { 
            ContactImg = "../assets/images/faces/14.jpg", 
            ContactName = "John", 
            ContactDetails = "Aug,10 2024 - 3:25PM", 
            ContactId = "685",       
            Email="John789@gmail.com", 
            Phone = "1902-2001-3023",
            Company="Logitech ecostics", 
            CompanyImg = "../assets/images/company-logos/4.png", 
            LeadSource = "Blog Articles", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "Partner",statusColor="success-transparent"},
            }
        },
        new CrmContact { 
            ContactImg = "../assets/images/faces/6.jpg", 
            ContactName = "Olivia", 
            ContactDetails = "Aug,18 2024 - 10:10AM", 
            ContactId = "425",       
            Email="Olivia290@gmail.com", 
            Phone = "1603-2032-1123",
            Company="Initech Info", 
            CompanyImg = "../assets/images/company-logos/5.png", 
            LeadSource = "Affiliates", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "LostCustomer",statusColor="light text-default"},
                new TagItem { status = "Influencer ",statusColor="secondary-transparent"},
            }
        },
        new CrmContact { 
            ContactImg = "../assets/images/faces/8.jpg", 
            ContactName = "Sophia", 
            ContactDetails = "Jul,19 2024 - 12:41PM", 
            ContactId = "516",       
            Email="Sophia1993@gmail.com", 
            Phone = "1129-2302-1092",
            Company="Massive Dynamic", 
            CompanyImg = "../assets/images/company-logos/6.png", 
            LeadSource = "Organic search", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "Subscriber",statusColor="pink-transparent"},
                new TagItem { status = "Partner ",statusColor="success-transparent"},
            }
        },
        new CrmContact { 
            ContactImg = "../assets/images/faces/9.jpg", 
            ContactName = "Jack Miller", 
            ContactDetails = "Aug,14 2024 - 5:18PM", 
            ContactId = "127",       
            Email="jackmiller345@gmail.com", 
            Phone = "9923-2344-2003",
            Company="Globex Corporation", 
            CompanyImg = "../assets/images/company-logos/7.png", 
            LeadSource = "Social media", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "Hot Lead",statusColor="danger-transparent"},
                new TagItem { status = "Referral ",statusColor="info-transparent"},
            }
        },
        new CrmContact { 
            ContactImg = "../assets/images/faces/15.jpg", 
            ContactName = "Michael", 
            ContactDetails = "Jun,12 2024 - 11:38AM", 
            ContactId = "368",       
            Email="Michael78@gmail.com", 
            Phone = "7891-2093-1994",
            Company="Acme Corporation", 
            CompanyImg = "../assets/images/company-logos/8.png", 
            LeadSource = "Blog Articles", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "Trial User",statusColor="warning-transparent"},
                new TagItem { status = "Cold Lead ",statusColor="purple-transparent"},
            }
        },
        new CrmContact { 
            ContactImg = "../assets/images/faces/1.jpg", 
            ContactName = "Emma", 
            ContactDetails = "May,19 2024 - 1:57PM", 
            ContactId = "563",       
            Email="Emma678@gmail.com", 
            Phone = "1899-2993-0923",
            Company="Soylent Corp", 
            CompanyImg = "../assets/images/company-logos/9.png", 
            LeadSource = "Organic search", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "Influencer",statusColor="success-transparent"},
                new TagItem { status = "Partner ",statusColor="info-transparent"},
            }
        },
        new CrmContact { 
            ContactImg = "../assets/images/faces/3.jpg", 
            ContactName = "Isabella", 
            ContactDetails = "Jul,28 2024 - 9:31AM", 
            ContactId = "185",       
            Email="Isabella289@gmail.com", 
            Phone = "1768-2332-4934",
            Company="Umbrella Corporation", 
            CompanyImg = "../assets/images/company-logos/10.png", 
            LeadSource = "Affiliates", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "New Lead",statusColor="primary-transparent"},
                new TagItem { status = "Lost Customer ",statusColor="light text-default"},
            }
        },
        new CrmContact { 
            ContactImg = "../assets/images/faces/9.jpg", 
            ContactName = "William", 
            ContactDetails = "Jul,28 2024 - 9:31AM", 
            ContactId = "240",       
            Email="William186@gmail.com", 
            Phone = "4788-7822-4786",
            Company="Hooli Technologies", 
            CompanyImg = "../assets/images/company-logos/2.png", 
            LeadSource = "	Direct mail", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "New Lead",statusColor="primary-transparent"},
                new TagItem { status = "Subscriber ",statusColor="pink-transparent"},
            }
        },
    };

    public List<CrmContact> GetCrmContact()
    {
        return CrmContactsLists;
    }


    public async Task DeleteCrmContact(string? ContactId)
    {
        var CrmContactToDelete = CrmContactsLists.FirstOrDefault(i => i.ContactId == ContactId);
        if (CrmContactToDelete != null)
        {
            CrmContactsLists.Remove(CrmContactToDelete);
            await Task.Delay(1000);
        }
    }
}
//  Crm Contacts Data End 
