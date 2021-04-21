using System;
using static OneOf.Functions;

namespace OneOf
{
    public struct OneOf<T0, T1, T2, T3, T4, T5, T6, T7> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly int _index;

        OneOf(int index, T0 value0 = default, T1 value1 = default, T2 value2 = default, T3 value3 = default, T4 value4 = default, T5 value5 = default, T6 value6 = default, T7 value7 = default)
        {
            _index = index;
            _value0 = value0;
            _value1 = value1;
            _value2 = value2;
            _value3 = value3;
            _value4 = value4;
            _value5 = value5;
            _value6 = value6;
            _value7 = value7;
        }

    public object Value { get {
                    switch (_index)
                    {
                            case 0: return _value0;
                case 1: return _value1;
                case 2: return _value2;
                case 3: return _value3;
                case 4: return _value4;
                case 5: return _value5;
                case 6: return _value6;
                case 7: return _value7;
                            default: throw new InvalidOperationException();
                        };
                } }

        public int Index => _index;

        public bool IsT0 => _index == 0;
        public bool IsT1 => _index == 1;
        public bool IsT2 => _index == 2;
        public bool IsT3 => _index == 3;
        public bool IsT4 => _index == 4;
        public bool IsT5 => _index == 5;
        public bool IsT6 => _index == 6;
        public bool IsT7 => _index == 7;

        public T0 AsT0 =>
            _index == 0 ?
                _value0 :
                throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
        public T1 AsT1 =>
            _index == 1 ?
                _value1 :
                throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
        public T2 AsT2 =>
            _index == 2 ?
                _value2 :
                throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
        public T3 AsT3 =>
            _index == 3 ?
                _value3 :
                throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
        public T4 AsT4 =>
            _index == 4 ?
                _value4 :
                throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
        public T5 AsT5 =>
            _index == 5 ?
                _value5 :
                throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
        public T6 AsT6 =>
            _index == 6 ?
                _value6 :
                throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
        public T7 AsT7 =>
            _index == 7 ?
                _value7 :
                throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");

        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T0 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(0, value0: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T1 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(1, value1: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T2 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(2, value2: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T3 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(3, value3: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T4 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(4, value4: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T5 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(5, value5: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T6 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(6, value6: t);
        public static implicit operator OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(T7 t) => new OneOf<T0, T1, T2, T3, T4, T5, T6, T7>(7, value7: t);

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            throw new InvalidOperationException();
        }

        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT0(T0 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT1(T1 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT2(T2 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT3(T3 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT4(T4 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT5(T5 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT6(T6 input) => input;
        public static OneOf<T0, T1, T2, T3, T4, T5, T6, T7> FromT7(T7 input) => input;

        
        public OneOf<TResult, T1, T2, T3, T4, T5, T6, T7> MapT0<TResult>(Func<T0, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return mapFunc(AsT0);
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, TResult, T2, T3, T4, T5, T6, T7> MapT1<TResult>(Func<T1, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return mapFunc(AsT1);
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, TResult, T3, T4, T5, T6, T7> MapT2<TResult>(Func<T2, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return mapFunc(AsT2);
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, TResult, T4, T5, T6, T7> MapT3<TResult>(Func<T3, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return mapFunc(AsT3);
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, TResult, T5, T6, T7> MapT4<TResult>(Func<T4, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return mapFunc(AsT4);
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return AsT7;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, TResult, T6, T7> MapT5<TResult>(Func<T5, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return mapFunc(AsT5);
                case 6: return AsT6;
                case 7: return AsT7;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, TResult, T7> MapT6<TResult>(Func<T6, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return mapFunc(AsT6);
                case 7: return AsT7;
                  default: throw new InvalidOperationException();
            }
        }
            
        public OneOf<T0, T1, T2, T3, T4, T5, T6, TResult> MapT7<TResult>(Func<T7, TResult> mapFunc)
        {
            if (mapFunc == null)
            {
                throw new ArgumentNullException(nameof(mapFunc));
            }
            switch (_index)
            {
                case 0: return AsT0;
                case 1: return AsT1;
                case 2: return AsT2;
                case 3: return AsT3;
                case 4: return AsT4;
                case 5: return AsT5;
                case 6: return AsT6;
                case 7: return mapFunc(AsT7);
                  default: throw new InvalidOperationException();
            }
        }

        public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7> remainder)
        {
            value = IsT0 ? AsT0 : default;
            switch (_index)
            {
                case 0: { remainder = default; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT0;
        }
        
        public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7> remainder)
        {
            value = IsT1 ? AsT1 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = default; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT1;
        }
        
        public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7> remainder)
        {
            value = IsT2 ? AsT2 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = default; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT2;
        }
        
        public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7> remainder)
        {
            value = IsT3 ? AsT3 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = default; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT3;
        }
        
        public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7> remainder)
        {
            value = IsT4 ? AsT4 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = default; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT4;
        }
        
        public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7> remainder)
        {
            value = IsT5 ? AsT5 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = default; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = AsT7; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT5;
        }
        
        public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7> remainder)
        {
            value = IsT6 ? AsT6 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = default; break; }
                case 7: { remainder = AsT7; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT6;
        }
        
        public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6> remainder)
        {
            value = IsT7 ? AsT7 : default;
            switch (_index)
            {
                case 0: { remainder = AsT0; break; }
                case 1: { remainder = AsT1; break; }
                case 2: { remainder = AsT2; break; }
                case 3: { remainder = AsT3; break; }
                case 4: { remainder = AsT4; break; }
                case 5: { remainder = AsT5; break; }
                case 6: { remainder = AsT6; break; }
                case 7: { remainder = default; break; }
                default: throw new InvalidOperationException();
            }
            return this.IsT7;
        }

        bool Equals(OneOf<T0, T1, T2, T3, T4, T5, T6, T7> other) {
            var check1 = _index == other._index;
            if (!check1) { return false; }
            switch (_index)
            {
                case 0: return check1 && Equals(_value0, other._value0);
                             case 1: return check1 && Equals(_value1, other._value1);
                             case 2: return check1 && Equals(_value2, other._value2);
                             case 3: return check1 && Equals(_value3, other._value3);
                             case 4: return check1 && Equals(_value4, other._value4);
                             case 5: return check1 && Equals(_value5, other._value5);
                             case 6: return check1 && Equals(_value6, other._value6);
                             case 7: return check1 && Equals(_value7, other._value7);
                default: return false;
            };
                             }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            return obj is OneOf<T0, T1, T2, T3, T4, T5, T6, T7> o && Equals(o);
        }

        public override string ToString() {
            switch (_index) {
                case 0: return FormatValue(_value0);
                case 1: return FormatValue(_value1);
                case 2: return FormatValue(_value2);
                case 3: return FormatValue(_value3);
                case 4: return FormatValue(_value4);
                case 5: return FormatValue(_value5);
                case 6: return FormatValue(_value6);
                case 7: return FormatValue(_value7);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
                                 }

        public override int GetHashCode()
        {
            unchecked
            {
                    int hashCode;
                    switch (_index)
                {
                    case 0: { hashCode = _value0?.GetHashCode() ?? 0; break; }
                    case 1: { hashCode = _value1?.GetHashCode() ?? 0; break; }
                    case 2: { hashCode = _value2?.GetHashCode() ?? 0; break; }
                    case 3: { hashCode = _value3?.GetHashCode() ?? 0; break; }
                    case 4: { hashCode = _value4?.GetHashCode() ?? 0; break; }
                    case 5: { hashCode = _value5?.GetHashCode() ?? 0; break; }
                    case 6: { hashCode = _value6?.GetHashCode() ?? 0; break; }
                    case 7: { hashCode = _value7?.GetHashCode() ?? 0; break; }
                    default: { hashCode = 0; break; }
                }
                return (hashCode*397) ^ _index;
            }
        }
    }
}
