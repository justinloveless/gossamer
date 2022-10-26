using System;

public class Message {
    public string MessageId { get; set; }
    public string SenderId { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    public List<string> ReadReceipts { get; set; }
}