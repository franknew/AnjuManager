using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOAFramework.Client.Controls
{
    public class CustomBindingSource : BindingSource
    {
    }

    public class CustomBinding : Binding
    {
        #region contructor
        public CustomBinding(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode, object nullValue, string formatString, IFormatProvider formatInfo) : base(propertyName, dataSource, dataMember, formattingEnabled, dataSourceUpdateMode, nullValue, formatString, formatInfo)
        { }

        public CustomBinding(string propertyName, object dataSource, string dataMember)
            : base(propertyName, dataSource, dataMember)
        { }
        //
        // 摘要:
        //     初始化 System.Windows.Forms.Binding 类的一个新实例，该实例将指示的控件属性绑定到数据源的指定数据成员，并启用要应用的格式设置（可选）。
        //
        // 参数:
        //   propertyName:
        //     要绑定的控件属性的名称。
        //
        //   dataSource:
        //     一个 System.Object，它代表数据源。
        //
        //   dataMember:
        //     要绑定到的属性或列表。
        //
        //   formattingEnabled:
        //     若要格式化显示的数据，则为 true；否则为 false。
        //
        // 异常:
        //   T:System.ArgumentException:
        //     在该控件中不存在由 propertyName 给出的属性。- 或 -给定的属性为只读属性。
        //
        //   T:System.Exception:
        //     禁用格式设置，且 propertyName 既不是有效的控件属性，也不是空字符串 ("")。
        public CustomBinding(string propertyName, object dataSource, string dataMember, bool formattingEnabled)
            : base(propertyName, dataSource, dataMember, formattingEnabled)
        { }
        //
        // 摘要:
        //     初始化 System.Windows.Forms.Binding 类的新实例，该实例将指定的控件属性绑定到指定数据源的指定数据成员。（可选）根据指定的更新设置，启用格式设置并将值传播到数据源。
        //
        // 参数:
        //   propertyName:
        //     要绑定的控件属性的名称。
        //
        //   dataSource:
        //     表示数据源的 System.Object。
        //
        //   dataMember:
        //     要绑定到的属性或列表。
        //
        //   formattingEnabled:
        //     若要格式化显示的数据，则为 true；否则为 false。
        //
        //   dataSourceUpdateMode:
        //     System.Windows.Forms.DataSourceUpdateMode 值之一。
        //
        // 异常:
        //   T:System.ArgumentException:
        //     在该控件中不存在由 propertyName 给出的属性。- 或 -指定的数据源、数据成员或控件属性与集合中的另一个绑定相关联。
        public CustomBinding(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode)
            : base (propertyName, dataSource, dataMember, formattingEnabled, dataSourceUpdateMode)
        { }
        //
        // 摘要:
        //     初始化 System.Windows.Forms.Binding 类的新实例，该实例将指示的控件属性绑定到指定数据源的指定数据成员。（可选）根据指定的更新设置，启用格式设置并将值传播到数据源，然后在从数据源返回
        //     System.DBNull 时将该属性设置为指定值。
        //
        // 参数:
        //   propertyName:
        //     要绑定的控件属性的名称。
        //
        //   dataSource:
        //     表示数据源的 System.Object。
        //
        //   dataMember:
        //     要绑定到的属性或列表。
        //
        //   formattingEnabled:
        //     若要格式化显示的数据，则为 true；否则为 false。
        //
        //   dataSourceUpdateMode:
        //     System.Windows.Forms.DataSourceUpdateMode 值之一。
        //
        //   nullValue:
        //     当数据源值为 System.DBNull 时要应用于绑定控件属性的 System.Object。
        //
        // 异常:
        //   T:System.ArgumentException:
        //     在该控件中不存在由 propertyName 给出的属性。- 或 -指定的数据源、数据成员或控件属性与集合中的另一个绑定相关联。
        public CustomBinding(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode, object nullValue) : base(propertyName, dataSource, dataMember,formattingEnabled, dataSourceUpdateMode, nullValue)
        { }
        //
        // 摘要:
        //     初始化 System.Windows.Forms.Binding 类的新实例，该实例将指定的控件属性绑定到指定数据源的指定数据成员。（可选）允许用指定的格式字符串进行格式设置；根据指定的更新设置将值传播到数据源；在从数据源返回
        //     System.DBNull 时将该属性设置为指定的值。
        //
        // 参数:
        //   propertyName:
        //     要绑定的控件属性的名称。
        //
        //   dataSource:
        //     表示数据源的 System.Object。
        //
        //   dataMember:
        //     要绑定到的属性或列表。
        //
        //   formattingEnabled:
        //     若要格式化显示的数据，则为 true；否则为 false。
        //
        //   dataSourceUpdateMode:
        //     System.Windows.Forms.DataSourceUpdateMode 值之一。
        //
        //   nullValue:
        //     当数据源值为 System.DBNull 时要应用于绑定控件属性的 System.Object。
        //
        //   formatString:
        //     一个或多个格式说明符，指示如何显示值。
        //
        // 异常:
        //   T:System.ArgumentException:
        //     在该控件中不存在由 propertyName 给出的属性。- 或 -指定的数据源、数据成员或控件属性与集合中的另一个绑定相关联。
        public CustomBinding(string propertyName, object dataSource, string dataMember, bool formattingEnabled, DataSourceUpdateMode dataSourceUpdateMode, object nullValue, string formatString) : base(propertyName, dataSource, dataMember, formattingEnabled, dataSourceUpdateMode, nullValue, formatString)
        { }
        #endregion
        
    }
}
