using System.ComponentModel.DataAnnotations;

namespace MessageContract
{
    public enum PushNotificationType
    {
        [Display(Name = "فایل ارسالی دارای ستون شماره موبایل است.")]
        MobileNo = 1,
        [Display(Name = "فایل ارسالی دارای ستون کد شناسه شماره موبایل است.")]
        MobileId = 2,
        [Display(Name = "فایل ارسالی دارای ستون کد شناسه موبایل اپلیکیشن است.")]
        MobileAppId = 3,
        [Display(Name = "ارسال به تمام مشترکین")]
        SendAllSubscriber = 9
    }
}