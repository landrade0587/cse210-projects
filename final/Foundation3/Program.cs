using System;

class Program
{    
    static void Main(string[] args)
    {
        DateOnly date1 = new DateOnly(2023,7,20);
        DateOnly date2 = new DateOnly(2023,8,7);
        DateOnly date3 = new DateOnly(2023,9,15);

        TimeOnly time1 = new TimeOnly(17,00);
        TimeOnly time2 = new TimeOnly(19,00);
        TimeOnly time3 = new TimeOnly(20,00);

        Address address1 = new Address("Street 130 #9-87 tower 37 apartment 201", "Barranquilla", "Atlantico", "Colombia");
        Address address2 = new Address("Carrera 18a #151-06", "Bogota", "Cundinamarca", "Colombia");
        Address address3 = new Address("Carera 34 #68-05", "Barranquilla", "Atlantico", "Colombia");       
        
        LectureEvent lecture = new LectureEvent("Lecture on the Atonement of Jesus Christ", "Description title", 
                                                date1, time1, address1, "Speaker 1", 250);
        ReceptionEvent reception = new ReceptionEvent("Reception event title", "Reception Description", 
                                                      date2, time2, address2, "landrade0587@gmail.com", "Accept");
        OutdoorGatheringEvent outdoorGathering = new OutdoorGatheringEvent("Outdoor event title", "Outdoor Description", 
                                                                           date3, time3, address3, 23, 80);

        Console.WriteLine("Lecture Envent: ***********************************************");
        lecture.LectureFullDetailsMessage();
        lecture.StandardDetailsMessage();
        lecture.ShortDescriptionMessage(lecture.GetType().ToString());

        Console.WriteLine("Reception Envent: ***********************************************");
        reception.ReceptionFullDetailsMessage();
        reception.StandardDetailsMessage();
        reception.ShortDescriptionMessage(reception.GetType().ToString());

        Console.WriteLine("Outdoor Envent: ***********************************************");
        outdoorGathering.OutdoorFullDetailsMessage();
        outdoorGathering.StandardDetailsMessage();
        outdoorGathering.ShortDescriptionMessage(outdoorGathering.GetType().ToString());       
    }
}
