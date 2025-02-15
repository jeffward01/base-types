﻿namespace TestApp;

[Int] public partial record struct MyInt;

[Double] public partial record struct MyDouble;

[Decimal] public partial record struct MyDecimal;

[Guid] public partial record struct MyGuid;

[DateTime] public partial record struct MyDateTime;

[String] public partial record MyString;

[MinInt(-100)] public partial record MyMinInt;

[MaxInt(100)] public partial record MyMaxInt;

[MinMaxInt(-10, 10)] public partial record MyMinMaxInt;

[PositiveDecimal] public partial record MyPositiveDecimal;

[NonEmptyGuid] public partial record MyNonEmptyGuid;

[NonEmptyString] public partial record MyNonEmptyString;

[MinLengthString(5)] public partial record MyMinLengthString;

[MaxLengthString(25)] public partial record MyMaxLengthString;

[MinMaxLengthString(10, 30)] public partial record MinMaxLengthString;

[RegexString(@"\d\w")] public partial record MyRegexString;
