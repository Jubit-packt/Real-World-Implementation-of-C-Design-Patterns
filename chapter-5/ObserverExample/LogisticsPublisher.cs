﻿namespace ObserverExample;

public class LogisticsPublisher
{
    private readonly List<ILogisticSubscriber> _logisticsSubscribers;

    public LogisticsPublisher()
    {
        _logisticsSubscribers = new List<ILogisticSubscriber>();
    }

    public void Subscribe(ILogisticSubscriber subscriber)
    {
        _logisticsSubscribers.Add(subscriber);
        PrintSubscribers();
    }

    public void Unsubscribe(ILogisticSubscriber subscriber)
    {
        _logisticsSubscribers.Remove(subscriber);
        PrintSubscribers();
    }

    private void PrintSubscribers()
    {
        switch (_logisticsSubscribers.Count)
        {
            case < 1:
                Console.WriteLine("There are no subscribers.");
                break;
            case 1:
                Console.WriteLine("There is 1 subscriber");
                break;
            default:
                Console.WriteLine("There are " + _logisticsSubscribers.Count + " subscribers.");
                break;
        }
    }
    public void NotifyPickupAvailable()
    {
        foreach (var subscriber in _logisticsSubscribers)
        {
            subscriber.SchedulePickup();
        }
    }
}