using System;

namespace Bài_Tập_lớn_Window.Common
{
    // Event bus for simple cross-control notifications
    public static class EventBus
    {
        // Raised when PhieuMuon data changes (created/updated/returned)
        public static event Action PhieuMuonChanged;

        public static void RaisePhieuMuonChanged()
        {
            PhieuMuonChanged?.Invoke();
        }
    }
}
