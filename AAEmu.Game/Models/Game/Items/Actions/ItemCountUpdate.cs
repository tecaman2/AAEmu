using AAEmu.Commons.Network;

namespace AAEmu.Game.Models.Game.Items.Actions
{
    public class ItemCountUpdate : ItemTask
    {
        private Item _item;
        private int _count;

        public ItemCountUpdate(Item item, int count)
        {
            _type = 4;
            _item = item;
            _count = count;
        }

        public override PacketStream Write(PacketStream stream)
        {
            base.Write(stream);
            stream.Write((byte) 0); // v
            stream.Write((byte) _item.SlotType); // v
            stream.Write((byte) 0); // v
            stream.Write((byte) _item.Slot); // v
            stream.Write(_item.Id);
            stream.Write(_count);
            stream.Write(_item.TemplateId);
            return stream;
        }
    }
}