﻿using Notepad.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Notepad.ViewModel.Commands
{
    public class EndEditingCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public NotesVM ViewModel { get; set; }

        public EndEditingCommand(NotesVM vm)
        {
            ViewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Notebook notebook = parameter as Notebook;
            if (notebook != null)
                ViewModel.StopEditing(notebook);
        }
    }
}
