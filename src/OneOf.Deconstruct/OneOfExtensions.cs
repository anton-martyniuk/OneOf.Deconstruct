// ReSharper disable once CheckNamespace
namespace OneOf
{
    /// <summary>
    /// Extension methods for OneOf that offers a deconstruction
    /// </summary>
    public static class OneOfExtensions
    {
        /// <summary>
        /// Deconstructs 1 parameter OneOf
        /// </summary>
        public static void Deconstruct<T0>(
            this OneOf<T0> oneOf,
            out T0? val0)
        {
            val0 = (oneOf.IsT0 ? oneOf.AsT0 : default)!;
        }
        
        /// <summary>
        /// Deconstructs 2 parameters OneOf
        /// </summary>
        public static void Deconstruct<T0, T1>(
            this OneOf<T0, T1> oneOf,
            out T0? val0,
            out T1? val1)
        {
            val0 = (oneOf.IsT0 ? oneOf.AsT0 : default)!;
            val1 = (oneOf.IsT1 ? oneOf.AsT1 : default)!;
        }
    
        /// <summary>
        /// Deconstructs 3 parameters OneOf
        /// </summary>
        public static void Deconstruct<T0, T1, T2>(
            this OneOf<T0, T1, T2> oneOf,
            out T0? val0,
            out T1? val1,
            out T2? val2)
        {
            val0 = (oneOf.IsT0 ? oneOf.AsT0 : default)!;
            val1 = (oneOf.IsT1 ? oneOf.AsT1 : default)!;
            val2 = (oneOf.IsT2 ? oneOf.AsT2 : default)!;
        }
        
        /// <summary>
        /// Deconstructs 4 parameters OneOf
        /// </summary>
        public static void Deconstruct<T0, T1, T2, T3>(
            this OneOf<T0, T1, T2, T3> oneOf,
            out T0? val0,
            out T1? val1,
            out T2? val2,
            out T3? val3)
        {
            val0 = (oneOf.IsT0 ? oneOf.AsT0 : default)!;
            val1 = (oneOf.IsT1 ? oneOf.AsT1 : default)!;
            val2 = (oneOf.IsT2 ? oneOf.AsT2 : default)!;
            val3 = (oneOf.IsT3 ? oneOf.AsT3 : default)!;
        }

        /// <summary>
        /// Deconstructs 5 parameters OneOf
        /// </summary>
        public static void Deconstruct<T0, T1, T2, T3, T4>(
            this OneOf<T0, T1, T2, T3, T4> oneOf,
            out T0? val0,
            out T1? val1,
            out T2? val2,
            out T3? val3,
            out T4? val4)
        {
            val0 = (oneOf.IsT0 ? oneOf.AsT0 : default)!;
            val1 = (oneOf.IsT1 ? oneOf.AsT1 : default)!;
            val2 = (oneOf.IsT2 ? oneOf.AsT2 : default)!;
            val3 = (oneOf.IsT3 ? oneOf.AsT3 : default)!;
            val4 = (oneOf.IsT4 ? oneOf.AsT4 : default)!;
        }
        
        /// <summary>
        /// Deconstructs 6 parameters OneOf
        /// </summary>
        public static void Deconstruct<T0, T1, T2, T3, T4, T5>(
            this OneOf<T0, T1, T2, T3, T4, T5> oneOf,
            out T0? val0,
            out T1? val1,
            out T2? val2,
            out T3? val3,
            out T4? val4,
            out T5? val5)
        {
            val0 = (oneOf.IsT0 ? oneOf.AsT0 : default)!;
            val1 = (oneOf.IsT1 ? oneOf.AsT1 : default)!;
            val2 = (oneOf.IsT2 ? oneOf.AsT2 : default)!;
            val3 = (oneOf.IsT3 ? oneOf.AsT3 : default)!;
            val4 = (oneOf.IsT4 ? oneOf.AsT4 : default)!;
            val5 = (oneOf.IsT5 ? oneOf.AsT5 : default)!;
        }

        /// <summary>
        /// Deconstructs 7 parameters OneOf
        /// </summary>
        public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6>(
            this OneOf<T0, T1, T2, T3, T4, T5, T6> oneOf,
            out T0? val0,
            out T1? val1,
            out T2? val2,
            out T3? val3,
            out T4? val4,
            out T5? val5,
            out T6? val6)
        {
            val0 = (oneOf.IsT0 ? oneOf.AsT0 : default)!;
            val1 = (oneOf.IsT1 ? oneOf.AsT1 : default)!;
            val2 = (oneOf.IsT2 ? oneOf.AsT2 : default)!;
            val3 = (oneOf.IsT3 ? oneOf.AsT3 : default)!;
            val4 = (oneOf.IsT4 ? oneOf.AsT4 : default)!;
            val5 = (oneOf.IsT5 ? oneOf.AsT5 : default)!;
            val6 = (oneOf.IsT6 ? oneOf.AsT6 : default)!;
        }

        /// <summary>
        /// Deconstructs 8 parameters OneOf
        /// </summary>
        public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>(
            this OneOf<T0, T1, T2, T3, T4, T5, T6, T7> oneOf,
            out T0? val0,
            out T1? val1,
            out T2? val2,
            out T3? val3,
            out T4? val4,
            out T5? val5,
            out T6? val6,
            out T7? val7)
        {
            val0 = (oneOf.IsT0 ? oneOf.AsT0 : default)!;
            val1 = (oneOf.IsT1 ? oneOf.AsT1 : default)!;
            val2 = (oneOf.IsT2 ? oneOf.AsT2 : default)!;
            val3 = (oneOf.IsT3 ? oneOf.AsT3 : default)!;
            val4 = (oneOf.IsT4 ? oneOf.AsT4 : default)!;
            val5 = (oneOf.IsT5 ? oneOf.AsT5 : default)!;
            val6 = (oneOf.IsT6 ? oneOf.AsT6 : default)!;
            val7 = (oneOf.IsT7 ? oneOf.AsT7 : default)!;
        }


        /// <summary>
        /// Deconstructs 9 parameters OneOf
        /// </summary>
        public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>(
            this OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> oneOf,
            out T0? val0,
            out T1? val1,
            out T2? val2,
            out T3? val3,
            out T4? val4,
            out T5? val5,
            out T6? val6,
            out T7? val7,
            out T8? val8)
        {
            val0 = (oneOf.IsT0 ? oneOf.AsT0 : default)!;
            val1 = (oneOf.IsT1 ? oneOf.AsT1 : default)!;
            val2 = (oneOf.IsT2 ? oneOf.AsT2 : default)!;
            val3 = (oneOf.IsT3 ? oneOf.AsT3 : default)!;
            val4 = (oneOf.IsT4 ? oneOf.AsT4 : default)!;
            val5 = (oneOf.IsT5 ? oneOf.AsT5 : default)!;
            val6 = (oneOf.IsT6 ? oneOf.AsT6 : default)!;
            val7 = (oneOf.IsT7 ? oneOf.AsT7 : default)!;
            val8 = (oneOf.IsT8 ? oneOf.AsT8 : default)!;
        }
    }
}