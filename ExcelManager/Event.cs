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

        public Event(DateTime date, TimeSpan startAt, TimeSpan endAt, string clientName, uint workerId, uint serviceId = 0)
        {
            Date = date;
            StartAt = startAt;
            EndAt = endAt;
            ClientName = clientName;
            WorkerID = workerId;
            if (serviceId != 0)
            {
                ServiceID = serviceId;
            }
            else
            {
                ServiceID = (uint)GetHashCode();
            }
        }
    }
}
