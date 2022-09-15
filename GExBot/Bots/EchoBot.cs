using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace EchoBot.Bots
{
    public class EchoBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            var replyText = $"Echo: {turnContext.Activity.Text}";
            await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
            await DisplayOptionsAsync(turnContext, cancellationToken);
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "Hello and welcome!";
            foreach (var member in membersAdded)
            {
                if (member.Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext.SendActivityAsync(MessageFactory.Text(welcomeText, welcomeText), cancellationToken);
                    await DisplayOptionsAsync(turnContext, cancellationToken);
                }
            }
        }


        private static async Task DisplayOptionsAsync(ITurnContext turnContext, CancellationToken cancellationToken)
        {
            // Create a HeroCard with options for the user to interact with the bot.
            var card = new HeroCard
            {
                Title = "ตลาดขยะอ่างน้ำพาน",
                Subtitle = "ศูนย์ซื้อ-ขาย แลกเปลี่ยนขยะชุมชนอ่างน้ำพาน",
                Text = "You can upload an image or select one of the following choices",
                Buttons = new List<CardAction>
                {
                    // Note that some channels require different values to be used in order to get buttons to display text.
                    // In this code the emulator is accounted for with the 'title' parameter, but in other channels you may
                    // need to provide a value for other parameters like 'text' or 'displayText'.
                    new CardAction(ActionTypes.OpenUrl, title: "1. ต้องการซื้อ", value: "http://localhost:8100/sell"),
                    new CardAction(ActionTypes.OpenUrl, title: "2. ต้องการเสนอขาย", value: "http://localhost:8100/bid"),
                    new CardAction(ActionTypes.ImBack, title: "3. ตรวจสอบสถานะ", value: "3"),
                },
                Images = new List<CardImage>
                {
                    new CardImage("http://localhost:3978/images/brand-logo.jpg", "Action Now!"),
                }
            };

            var reply = MessageFactory.Attachment(card.ToAttachment());
            await turnContext.SendActivityAsync(reply, cancellationToken);
        }
    }
}