using System;

namespace ExcelManager
{
    public class Event
    {
        public DateTime Date { get; private set; }
        public TimeSpan StartAt { get; private set; }
        public TimeSpan EndAt { get; private set; }
        // В последующем здесь можно использовать абстрактный объект клиент
        public string ClientName { get; private set; }
        public uint ServiceID { get; private set; }
        public uint WorkerID { get; private set; }

        public Event(DateTime date, TimeSpan startAt, TimeSpan endAt, string clientName, uint serviceId, uint workerId)
        {
            Date = date;
            StartAt = startAt;
            EndAt = endAt;
            ClientName = clientName;
            ServiceID = serviceId;
            WorkerID = workerId;
        }
    }
}
