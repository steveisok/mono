//------------------------------------------------------------------------------
// <copyright file="ConnectionProviderAttribute.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace System.Web.UI.WebControls.WebParts {

    using System;
    using System.ComponentModel;
    using System.Reflection;

    [AttributeUsage(AttributeTargets.Method)]
    public class ConnectionProviderAttribute : Attribute {

        private string _displayName;
        private string _id;
        private Type _connectionPointType;
        private bool _allowsMultipleConnections;

        public ConnectionProviderAttribute(string displayName) {
            if (String.IsNullOrEmpty(displayName)) {
                throw new ArgumentNullException("displayName");
            }

            _displayName = displayName;
            _allowsMultipleConnections = true;
        }

        public ConnectionProviderAttribute(string displayName, string id) : this(displayName) {
            if (String.IsNullOrEmpty(id)) {
                throw new ArgumentNullException("id");
            }

            _id = id;
        }

        public ConnectionProviderAttribute(string displayName, Type connectionPointType) : this(displayName) {
            if (connectionPointType == null) {
                throw new ArgumentNullException("connectionPointType");
            }

            _connectionPointType = connectionPointType;
        }

        public ConnectionProviderAttribute(string displayName, string id, Type connectionPointType) : this(displayName, connectionPointType) {
            if (String.IsNullOrEmpty(id)) {
                throw new ArgumentNullException("id");
            }

            _id = id;
        }

        public bool AllowsMultipleConnections {
            get {
                return _allowsMultipleConnections;
            }
            set {
                _allowsMultipleConnections = value;
            }
        }

        public string ID {
            get {
                return (_id != null) ? _id : String.Empty;
            }
        }

        public virtual string DisplayName {
            get {
                return DisplayNameValue;
            }
        }

        protected string DisplayNameValue {
            get {
                return _displayName;
            }
            set {
                _displayName = value;
            }
        }

        public Type ConnectionPointType {
            get {
                if (WebPartUtil.IsConnectionPointTypeValid(_connectionPointType, /*isConsumer*/ false)) {
                    return _connectionPointType;
                }
                else {
                    throw new InvalidOperationException(System.Web.SR.GetString(System.Web.SR.ConnectionProviderAttribute_InvalidConnectionPointType, _connectionPointType.Name));
                }
            }
        }
    }
}

