﻿using No_Vk.Domain.Models.Data;
using System;
using System.Linq;

namespace No_Vk.Domain.Models.Abstractions
{
    public interface IUserRepository : IDisposable
    {
        //Create
        public void AddUser(User user);
        public void AddChat(Chat chat);
        public void AddMessage(Message message);
        public void AddFriend(Friend friend);
        public void AddNotice(Notice notice);

        //Read
        public IQueryable<User> GetUsers();
        public User GetUser(string id);
        public IQueryable<Chat> GetChats();
        public Chat GetChat(string id);
        public IQueryable<Message> GetMessages();
        public Message GetMessage(string id);
        public IQueryable<Friend> GetFriends();
        public Friend GetFriend(string id);
        public IQueryable<Notice> GetNotices();
        public Notice GetNotice(string id);

        //Update
        public void UpdateUser(User user);
        public void UpdateChat(Chat chat);
        public void UpdateMessage(Message Message);
        public void UpdateFriend(Friend Friend);
        public void UpdateNotice(Notice Notice);

        //Delete
        public void DeleteUser(User user);
        public void DeleteChat(Chat chat);
        public void DeleteMessage(Message Message);
        public void DeleteFriend(Friend Friend);
        public void DeleteNotice(Notice Notice);



        public void Save();
    }
}
