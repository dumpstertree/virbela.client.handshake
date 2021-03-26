using TinyMessenger;

namespace Virbela.Events{

	public class FieldChangedEvent : ITinyMessage {

		public object Sender { get; private set; }
		public string Value { get; private set; }

		public FieldChangedEvent ( string val ) {
			Value = val;
		}
	}
}