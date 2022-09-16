using System;
public class Program {

 public static newKFC CreateKFC(string Capital,
  string Branch,
  string Locations) {
    return new newKFC(Capital,
    Branch,
    Locations);
 }
public static Owner owner(string OwnerName,
  string OwnerSurname,
  string citizenId) {
    return new Owner(OwnerName,
    OwnerSurname,
    citizenId);
  }
  
  public static Worker worker(string job,
  string WorkerName,
  string WorkerSurName,
  int Age,
  int JobMoney) {
    return new Worker(job,
    WorkerSurName,
    WorkerName,
    Age,
    JobMoney);
 }

 public static void Main(string[] args) {
     newKFC myKFC = CreateKFC("1000000", "bangKhunThian", "bangKhunThian thian ta la" );
     PrintKFCInformation(myKFC);
     
     Owner Owner1 = owner("Tave", "Jaideedee", "153-698-4561237" );
     Owner Owner2 = owner("Yutadee", "Tungjairean", "742-112-5687412" );
     Owner Owner3 = owner("Jame", "Rukrongrean", "541-772-3215689" );
     PrintOwnerInformation(Owner1);
     PrintOwnerInformation(Owner2);
     PrintOwnerInformation(Owner2);

     Worker worker1 = worker("Shopassistant", "Chaidee", "Rukdee", 20, 15000 );
     Worker worker2 = worker("Shopassistant", "Nondee", "jaidee", 18, 15000 );
     Worker worker3 = worker("Shopassistant", "Rpaidee", "Reandee", 22, 15000 );
     Worker worker4 = worker("Delivery", "Tondee", "kandee", 25, 12500 );
     Worker worker5 = worker("Delivery", "Nondee", "Leabdee", 23, 12500 );
     PrintWorkerInformation(worker1);
     PrintWorkerInformation(worker2);
     PrintWorkerInformation(worker3);
     PrintWorkerInformation(worker4);
     PrintWorkerInformation(worker5);


 }

 static void PrintKFCInformation(newKFC KFC1) {
    Console.WriteLine("-----------------------------");
    Console.WriteLine("Funds for registration of merchants: {0}", KFC1.Capital);
    Console.WriteLine("Branch Name: {0}", KFC1.Branch);
    Console.WriteLine("Locations: {0}", KFC1.Locations);
    Console.WriteLine("-----------------------------");
 }
static void PrintOwnerInformation(Owner Owner1) {
    
    Console.WriteLine("Owner Name: {0}", Owner1.OwnerName);
    Console.WriteLine("Owner Sername: {0}", Owner1.OwnerSurname);
    Console.WriteLine("citizen Id: {0}", Owner1.citizenId);
    Console.WriteLine("-----------------------------");
 }
static void PrintWorkerInformation(Worker worker1) {
    
    Console.WriteLine("Worker job: {0}", worker1.job);
    Console.WriteLine("Worker Name: {0}", worker1.WorkerName);
    Console.WriteLine("Worker Sername: {0}", worker1.WorkerSurname);
    Console.WriteLine("Age: {0}", worker1.Age);
    Console.WriteLine("JobMoney: {0}", worker1.JobMoney);
    Console.WriteLine("-----------------------------"); 
}
}
