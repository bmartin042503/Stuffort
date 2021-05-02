﻿using Stuffort.Model;
using Stuffort.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Stuffort.ViewModel.Commands
{
    public class TaskDoneCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            STask selectedItem = parameter as STask;
            if(selectedItem.IsDone == false)
            {
                selectedItem.IsDone = true;
                await STaskServices.UpdateTask(selectedItem);
                await App.Current.MainPage.DisplayAlert(AppResources.ResourceManager.GetString("Success"),
                    AppResources.ResourceManager.GetString("TaskCompleted"), "Ok");
            }
            else
            {
                selectedItem.IsDone = false;
                await STaskServices.UpdateTask(selectedItem);
                await App.Current.MainPage.DisplayAlert(AppResources.ResourceManager.GetString("Success"),
                    AppResources.ResourceManager.GetString("TaskUncompleted"), "Ok");
            }
        }
    }
}
