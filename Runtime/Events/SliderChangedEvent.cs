using TinyMessenger;

namespace Virbela.Events{

	public class SliderChangedEvent : ITinyMessage {

		public object Sender { get; private set; }
		public float Value { get; private set; }

		public SliderChangedEvent ( float val ) {
			Value = val;
		}
	}
}