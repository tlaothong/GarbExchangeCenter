using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace EchoBot.Bots
{
    public class EchoBot : ActivityHandler
    {
        // Dependency injected dictionary for storing ConversationReference objects used in NotifyController to proactively message users
        private readonly ConcurrentDictionary<string, ConversationReference> _conversationReferences;

        public EchoBot(ConcurrentDictionary<string, ConversationReference> conversationReferences)
        {
            this._conversationReferences = conversationReferences;
        }

        private void SetConversationReference(Activity activity)
        {
            var conversationReference = activity.GetConversationReference();
            _conversationReferences.AddOrUpdate(conversationReference.User.Id, conversationReference, (key, newValue) => conversationReference);
        }

        protected override Task OnConversationUpdateActivityAsync(ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            SetConversationReference(turnContext.Activity as Activity);

            return base.OnConversationUpdateActivityAsync(turnContext, cancellationToken);
        }

        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            SetConversationReference(turnContext.Activity as Activity);

            if (turnContext.Activity.Text == "สนใจซื้อ")
            {
                var replyText = $"กรุณาติดต่อคุณ ประภาส อำคา เบอร์โทร 0939314179 เพื่อซื้อขวดน้ำ PET ใส ในราคา 8.50 บาท/หน่วย";
                await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
            }
            else if (turnContext.Activity.Text == "ขายสินค้า")
            {
                var replyText = $"คุณได้ยืนยันขาย ขวดน้ำ PET ใส ในราคา 8.50 บาท/หน่วย จำนวน 30 กก. จะมีผู้ซื้อติดต่อมาภายใน 3 วัน หากพ้นกำหนดแล้วยังไม่มีผู้ซื้อติดต่อเข้ามา สามารถแจ้งระบบกลับมาเพื่อติดตามผู้ซื้ออีกครั้ง";
                await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
            }
            else
            {
                var replyText = $"คุณเลือก: {turnContext.Activity.Text}";
                await turnContext.SendActivityAsync(MessageFactory.Text(replyText, replyText), cancellationToken);
                await DisplayOptionsAsync(turnContext, cancellationToken);
            }
        }

        protected override async Task OnMembersAddedAsync(IList<ChannelAccount> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext, CancellationToken cancellationToken)
        {
            var welcomeText = "ยินดีต้อนรับสู่ศูนย์ซื้อขายขยะวิสาหกิจชุมชนท่าเรือทะเลบัวแดงดอนคง!";
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
                Title = "ตลาดขยะวิสาหกิจชุมชนท่าเรือทะเลบัวแดงดอนคง",
                Subtitle = "ศูนย์ซื้อ-ขาย แลกเปลี่ยนขยะวิสาหกิจชุมชนท่าเรือทะเลบัวแดงดอนคง",
                Text = "เลือกดำเนินการตามความต้องการได้จากปุ่มด้านล่าง",
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
                    new CardImage("http://localhost:3978/images/brand-logo2.jpg", "Action Now!"),
                }
            };

            var reply = MessageFactory.Attachment(card.ToAttachment());
            await turnContext.SendActivityAsync(reply, cancellationToken);
        }
    }
}