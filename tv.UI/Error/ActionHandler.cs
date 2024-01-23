namespace tv.UI.Error
{
    public static class ActionHandler
    {
        public static bool Handler(Action action)
        {
			try
			{
				action.Invoke();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
        }
    }
}
