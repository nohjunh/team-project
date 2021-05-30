﻿using Notice.Model;
using Notice.ViewModel.Command;
using Notice.ViewModel.Command.FirstPageCommand;
using Notice.ViewModel.Command.HomePageCommand;
using Notice.ViewModel.Command.LoginPageCommand;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notice.ViewModel
{
    public class ViewModel
    {
        /// <summary>
        /// HomePageCommand
        /// </summary>
        public List<DepartmentData> D_Data { get; set; }
        public ObservableCollection<DepartmentData> D_Data_Main { get; set; }
        public DepartmentDataButtonCommand departmentDataButtonCommand { get; set; }


        /// <summary>
        /// LoginPageCommand
        /// </summary>
        public MainWindowIDInformation mainWindowIDInformation { get; set; }
        public exitButtonCommand exitButtonCommand { get; set; }
        public signinButtonCommand loginButtonCommand { get; set; }

        /// <summary>
        /// FirstPageCommnad
        /// </summary>
        public listViewSelected listViewSelected { get; set; }

        /// <summary>
        /// BindingPageCommand
        /// </summary>
        public BindingButton bindingButton { get; set; }

        //Notice Page Command
        public List<LmsData1> L_Data1 { get; set; }
        public ObservableCollection<LmsData1> L_Data1_Main { get; set; }
        public LmsData1Command lmsData1Command { get; set; }

        public ViewModel()
        {

            D_Data = new List<DepartmentData>();
            D_Data_Main = new ObservableCollection<DepartmentData>();



            mainWindowIDInformation = new MainWindowIDInformation();
            exitButtonCommand = new exitButtonCommand();
            loginButtonCommand = new signinButtonCommand(this);
            bindingButton = new BindingButton();
           


            departmentDataButtonCommand = new DepartmentDataButtonCommand(this);
            listViewSelected = new listViewSelected();

            L_Data1 = new List<LmsData1>();
            L_Data1_Main = new ObservableCollection<LmsData1>();


        }

        public void get1()
        {
            for (int i = 0; i < L_Data1.Count(); i++)
            {
                L_Data1_Main.Add(L_Data1[i]);
            }
        }

        public void get4()
        {
            for (int i = 0; i < D_Data.Count(); i++)
            {
                D_Data_Main.Add(D_Data[i]);
            }
        }
    }
}
