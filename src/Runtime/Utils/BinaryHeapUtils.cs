using System.Runtime.CompilerServices;

namespace Nk7.DataStructures
{
    internal static class BinaryHeapUtils
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetLeftChildIndex(int index)
        {
            return (index << 1) + 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetRightChildIndex(int index)
        {
            return (index << 1) + 2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetParentIndex(int index)
        {
            return (index - 1) >> 1;
        }
    }
}