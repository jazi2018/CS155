using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_Lab1
{
    internal class Email : Document
    {
        private string sender, recipient, title;

        public Email() : base()
        {
            sender = "";
            recipient = "";
            title = "";
        }

        public Email(string sender, string recipient, string title, string text) : base(text)
        {
            this.sender = sender;
            this.recipient = recipient;
            this.title = title;
        }

        public string getSender() { return sender; }
        public string getRecipient() { return recipient; }
        public string getTitle() { return title; }

        public void setSender(string sender) { this.sender = sender; }
        public void setRecipient(string recipient) { this.recipient = recipient; }
        public void setTitle(string title) { this.title = title; }

        public new string ToString()
        {
            return $"Title: {this.title}\n" +
                $"Sender: {this.sender}\n" +
                $"Recipient: {this.recipient}\n" +
                $"Text: {base.ToString()}";
        }
    }
}
