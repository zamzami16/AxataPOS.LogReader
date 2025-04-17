using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace AxataPOS.LogReader;

public static class Helper
{
    public static DataTable ToDataTable<T>(this IEnumerable<T> data, string tableName = "")
    {
        PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
        DataTable table = new DataTable(tableName);
        foreach (PropertyDescriptor prop in properties)
        {
            table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
        }

        foreach (T item in data)
        {
            DataRow row = table.NewRow();
            foreach (PropertyDescriptor prop in properties)
                row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
            table.Rows.Add(row);
        }
        return table;
    }

    public static LogEntry ToLogEntry(this DataRow row)
    {
        var columns = new string[] { "level", "logger", "time", "exception", "message" };
        if (columns.All(c => row.Table.Columns.Contains(c)))
        {
            return new LogEntry()
            {
                Level = row.Field<string>("level"),
                Logger = row.Field<string>("logger"),
                Time = row.Field<DateTime>("time"),
                Exception = row.Field<string>("exception"),
                Message = row.Field<string>("message")
            };
        }
        return null;
    }
}
