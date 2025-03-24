using Syncfusion.Maui.Chat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMaui
{
    public class GettingStartedViewModel : INotifyPropertyChanged
    {
        #region Fields

        /// <summary>
        /// Collection of messages in a conversation.
        /// </summary>
        private ObservableCollection<object> messages;

        /// <summary>
        /// Current user of chat.
        /// </summary>
        private Author currentUser;

        #endregion

        #region Constructor
        public GettingStartedViewModel()
        {
            this.messages = new ObservableCollection<object>();
            this.currentUser = new Author() { Name = "Nancy", Avatar = "nancy.png"};
            this.GenerateMessages();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the collection of messages of a conversation.
        /// </summary>
        public ObservableCollection<object> Messages
        {
            get
            {
                return this.messages;
            }

            set
            {
                this.messages = value;
                RaisePropertyChanged(nameof(this.messages));    
            }
        }

        /// <summary>
        /// Gets or sets the current user of the message.
        /// </summary>
        public Author CurrentUser
        {
            get
            {
                return this.currentUser;
            }
            set
            {
                this.currentUser = value;
                RaisePropertyChanged("CurrentUser");
            }
        }

        #endregion

        #region Events

        /// <summary>
        /// Property changed handler.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion

        #region Methods

        /// <summary>
        /// Occurs when property is changed.
        /// </summary>
        /// <param name="propName">changed property name</param>
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private void GenerateMessages()
        {
            this.messages.Add(new TextMessage()
            {
                Author = currentUser,
                Text = "Hi guys, good morning! I'm very delighted to share with you the news that our team is going to launch a new mobile application.",
            });

            this.messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Andrea", Avatar = "Andrea.png" },
                Text = "Oh! That's great.",
            });

            this.messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Harrison", Avatar = "Harrison.png" },
                Text = "That is good news.",
            });

            this.messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Margaret", Avatar = "Margaret.png" },
                Text = "Are we going to develop the app natively or hybrid?"
            });

            this.messages.Add(new TextMessage()
            {
                Author = currentUser,
                Text = "We should develop this app in .NET MAUI, since it provides native experience and perfomance as well as allowing for seamless cross-platform development.",
            });
            this.messages.Add(new TextMessage()
            {
                Author = new Author() { Name = "Margaret", Avatar = "Margaret.png" },
                Text = "I haven't heard of .NET MAUI. What's .NET MAUI?",
            });
            this.messages.Add(new TextMessage()
            {
                Author = currentUser,
                Text = ".NET MAUI is a new library that lets you build native UIs for Android, iOS, macOS, and Windows from one shared C# codebase.",
            });
        }

        #endregion
    }
}

