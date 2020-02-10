using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using MailSender_lib.Entities;
using MailSender_lib.Service;
using MailSender_lib.Service.Interfaces;
using System.Windows.Input;

namespace MyMailSender.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IRecipientsManager _RecipientsManager;


        public ICommand LoadRecipientsDataCommand { get; }

        public ICommand SaveRecipientChangesCommand { get; }

        public MainViewModel(IRecipientsManager RecipientsManager)
        {
            SaveRecipientChangesCommand = new RelayCommand<Recipient>(OnSaveRecipientChangesCommandExecuted, CanSaveRecipientChangesCommandExecute);

            _RecipientsManager = RecipientsManager;
        }

        private bool CanSaveRecipientChangesCommandExecute(Recipient recipient)
        {
            System.Diagnostics.Debug.WriteLine("Проверка состояния команды " + recipient?.Name);
            return recipient != null;
        }

        private void OnSaveRecipientChangesCommandExecuted(Recipient recipient)
        {
            _RecipientsManager.Edit(recipient);
            _RecipientsManager.SaveChanges();
        }
    }
}