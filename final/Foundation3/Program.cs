using System;

class Program
{
    static void Main(string[] args)
    {

        //Lecture Event
        Address address1 = new Address("2194 Health Sciences Mall - Room 2", "Vancouver", "BC", "V6T 1Z3", "Canada");
        LectureEvent event1 = new LectureEvent("Changing Minds and Logic", "An analysis of how to investigate and look at the world with logic, and how we can change our own minds", "October 27th, 2023", "12:00 pm - 2:30 pm", address1, "Autumn Williams, PhD in Neural Pathway Mapping", 425);

        Address address2 = new Address("701 E University Parkway", "Provo", "UT", "84602", "USA");
        LectureEvent event2 = new LectureEvent("Weekly Devotional", "Topic to be announced prior to the event.", "October 24th, 2023", "11:30 am - 1:00 pm MST", address2, "Sister Kristin M. Yee", 10800);

        //Outdoor Event
        Address address3 = new Address("Main Beach Pavilion", "Culuts Lake", "BC", "V2R 4Y5", "Canada");
        OutdoorEvent event3 = new OutdoorEvent("Fall Dive In", "Jump in and cool off with the fall. Swim the main beach docks while bonfires on the beach are their to warm you up.", "Friday November 3rd, 2023", "4:00 pm - 7:30 pm", address3, "Rain, and temperatures between 5-16 degrees Celcius");

        Address address4 = new Address("Middle of Nowhere", "Some City", "Some State", "99999", "USA");
        OutdoorEvent event4 = new OutdoorEvent("Nurturing in Nature", "Spend time as a family with Guided hiking and outdoor Meditation", "October 17th, 2023", "10:00 am - 2:00 pm", address4, "Dress warm. Overcast and cloudy. Possibility of Rain.");

        //Reception Event
        Address address5 = new Address("Hotle Somwhere", "Nice City", "State", "11111", "USA");
        ReceptionEvent event5 = new ReceptionEvent("Kidman Wedding", "Come and Celebrate the wedding of Nicole Kidman and Tom Cruse", "December 24th, 2023", "5:00 pm - 9:00 pm", address5, "nkidman@wedding.com");

        Address address6 = new Address("Embassy for Some Country on X Street", "Vancouver", "BC", "V3X 8T9", "Canada");
        ReceptionEvent event6 = new ReceptionEvent("Welcome to our Embassy", "A Reception for dignitaries", "November 1st, 2023", "8:00 pm - 11:30 pm", address6, "ourembassy@gmail.com");

        //Sport Event
        Address address7 = new Address("Yankee Stadium 1 E 161 Street", "Bronx", "NY", "10451", "USA");
        SportEvent event7 = new SportEvent("Yankees vs. Red Socks", "Come for the Showdown of the Basseball Year", "During Baseball Season??", "4:00 pm - 9:00 pm", address7, "Baseball", 180);

        Address address8 = new Address("Allegiant Stadium - 3333 All Davis Way", "Las Vegas", "NV", "89118", "USA");
        SportEvent event8 = new SportEvent("Superbowl 2024", "Come for the Showdown", "February 11th, 2024", "1:00 pm - 5:00 pm", address8, "American Football", 120);

        // Display Standard 
        event1.StandardDetails();
        Console.WriteLine();
        event2.StandardDetails();
        Console.WriteLine();
        event3.StandardDetails();
        Console.WriteLine();
        event4.StandardDetails();
        Console.WriteLine();
        event5.StandardDetails();
        Console.WriteLine();
        event6.StandardDetails();
        Console.WriteLine();
        event7.StandardDetails();
        Console.WriteLine();
        event8.StandardDetails();
        Console.WriteLine();

        //Display Short
        event1.ShortDescription();
        Console.WriteLine();
        event2.ShortDescription();
        Console.WriteLine();
        event3.ShortDescription();
        Console.WriteLine();
        event4.ShortDescription();
        Console.WriteLine();
        event5.ShortDescription();
        Console.WriteLine();
        event6.ShortDescription();
        Console.WriteLine();
        event7.ShortDescription();
        Console.WriteLine();
        event8.ShortDescription();
        Console.WriteLine();

        //Display Full
        event1.FullDetails();
        Console.WriteLine();
        event2.FullDetails();
        Console.WriteLine();
        event3.FullDetails();
        Console.WriteLine();
        event4.FullDetails();
        Console.WriteLine();
        event5.FullDetails();
        Console.WriteLine();
        event6.FullDetails();
        Console.WriteLine();
        event7.FullDetails();
        Console.WriteLine();
        event8.FullDetails();
        Console.WriteLine();

    }
}