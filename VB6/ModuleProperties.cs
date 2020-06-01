using System;

namespace vb6.net.VB6
{
    public enum DataBindingBehavior
    {
        vbNone = 0,
        vbSimpleBound = 1,
        vbComplexBound = 2
    }

    public enum DataSourceBehavior
    {
        vbNone = 0,
        vbDataSource = 1
    }

    public enum Persistable
    {
        NotPersistable = 0,
        Persistable = 1
    }

    public enum Instancing
    {
        Private = 1,
        PublicNotCreatable = 2,
        MultiUse = 5,
        GlobalMultiUse = 6
    }

    public enum MTSTransactionMode
    {
        NotAnMTSObject = 0,
        NoTransactions = 1,
        RequiresTransaction = 2,
        UsesTransaction = 3,
        RequiresNewTransaction = 4
    }

    public class ModuleProperties
    {
        public bool MultiUse { get; set; }
        public Persistable Persistable { get; set; }
        public DataBindingBehavior DataBindingBehavior { get; set; }
        public DataSourceBehavior DataSourceBehavior { get; set; }
        public Instancing Instancing { get; set; }
        public MTSTransactionMode MTSTransactionMode { get; set; }

    }
}
