public class Worker {
    public string WorkerName;
    public string WorkerSurname;
    public string job;
    public int Age;
    public int JobMoney;

    public Worker(string job,
     string WorkerName,
     string WorkerSurname,
     int Age,
     int JobMoney) {
        this.job = job;
        this.WorkerName = WorkerName;
        this.WorkerSurname = WorkerSurname;
        this.Age = Age;
        this.JobMoney = JobMoney;
    }
}