using TinyMessenger;

namespace Virbela.Events {

	public class ToggleChangedEvent : ITinyMessage {

		public object Sender { get; private set; }
		public bool Value { get; private set; }

		public ToggleChangedEvent ( bool val ) {
			Value = val;
		}
	}
}