﻿using System.Threading;
using Melake.Data;
using Melake.Models;
using Melake.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Melake
{
    public partial class App : Application
    {

        static TokenDatabaseController tokenDatabase;
        static UserDatabaseController userDatabase;
        static RestService restService;
        private static Label labelScreen;
        private static bool hasInternet;
        private static Page currentpage;
        private static Timer timer;
        
        

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


        public static UserDatabaseController UserDatabase
        {

            get
            {

                if(userDatabase == null)
                {

                    userDatabase = new UserDatabaseController();
                }

                return userDatabase;


            }
        }

        public static TokenDatabaseController TokenDatabase
        {

            get
            {

                if (tokenDatabase == null)
                {

                    tokenDatabase = new TokenDatabaseController();
                }

                return tokenDatabase;


            }
        }


        public static RestService RestService
        {

            get
            {
                if(restService == null)
                {

                    restService = new RestService();
                }

                return restService;
            }
        }


        // ........................ Internet Connection --

        public static void StartCheckIfInternet(Label label, Page page)
        {

            labelScreen = label;
            label.Text = Constants.NoInternetText;
            label.IsVisible = false;
            hasInternet = true;
            currentpage = page;
           
        }


    }
}
