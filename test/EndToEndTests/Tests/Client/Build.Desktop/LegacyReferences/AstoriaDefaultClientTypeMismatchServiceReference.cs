﻿//---------------------------------------------------------------------
// <copyright file="Reference.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

// Generation date: 11/20/2013 7:14:10 PM
namespace Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference
{
    /// <summary>
    /// There are no comments for DefaultContainer in the schema.
    /// </summary>
    public partial class DefaultContainer : global::Microsoft.OData.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new DefaultContainer object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public DefaultContainer(global::System.Uri serviceRoot) :
            base(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            // The default language is changed to JSON from ATOM at V4, manually change the generate code to make sure we don't lose coverage.
            //this.Format.UseAtom();             
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "Microsoft.Test.OData.Services.AstoriaDefaultService", "Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference", global::System.StringComparison.Ordinal))
            {
                return string.Concat("Microsoft.Test.OData.Services.AstoriaDefaultService.", clientType.Name);
            }
            return clientType.FullName;
        }
        /// <summary>
        /// There are no comments for AllGeoTypesSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<AllSpatialTypes> AllGeoTypesSet
        {
            get
            {
                if ((this._AllGeoTypesSet == null))
                {
                    this._AllGeoTypesSet = base.CreateQuery<AllSpatialTypes>("AllGeoTypesSet");
                }
                return this._AllGeoTypesSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<AllSpatialTypes> _AllGeoTypesSet;
        /// <summary>
        /// There are no comments for AllGeoCollectionTypesSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<AllSpatialCollectionTypes> AllGeoCollectionTypesSet
        {
            get
            {
                if ((this._AllGeoCollectionTypesSet == null))
                {
                    this._AllGeoCollectionTypesSet = base.CreateQuery<AllSpatialCollectionTypes>("AllGeoCollectionTypesSet");
                }
                return this._AllGeoCollectionTypesSet;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<AllSpatialCollectionTypes> _AllGeoCollectionTypesSet;
        /// <summary>
        /// There are no comments for Customer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<Customer> Customer
        {
            get
            {
                if ((this._Customer == null))
                {
                    this._Customer = base.CreateQuery<Customer>("Customer");
                }
                return this._Customer;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Customer> _Customer;
        /// <summary>
        /// There are no comments for Login in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<Login> Login
        {
            get
            {
                if ((this._Login == null))
                {
                    this._Login = base.CreateQuery<Login>("Login");
                }
                return this._Login;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Login> _Login;
        /// <summary>
        /// There are no comments for RSAToken in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<RSAToken> RSAToken
        {
            get
            {
                if ((this._RSAToken == null))
                {
                    this._RSAToken = base.CreateQuery<RSAToken>("RSAToken");
                }
                return this._RSAToken;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<RSAToken> _RSAToken;
        /// <summary>
        /// There are no comments for PageView in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<PageView> PageView
        {
            get
            {
                if ((this._PageView == null))
                {
                    this._PageView = base.CreateQuery<PageView>("PageView");
                }
                return this._PageView;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<PageView> _PageView;
        /// <summary>
        /// There are no comments for LastLogin in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<LastLogin> LastLogin
        {
            get
            {
                if ((this._LastLogin == null))
                {
                    this._LastLogin = base.CreateQuery<LastLogin>("LastLogin");
                }
                return this._LastLogin;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<LastLogin> _LastLogin;
        /// <summary>
        /// There are no comments for Message in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<Message> Message
        {
            get
            {
                if ((this._Message == null))
                {
                    this._Message = base.CreateQuery<Message>("Message");
                }
                return this._Message;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Message> _Message;
        /// <summary>
        /// There are no comments for MessageAttachment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<MessageAttachment> MessageAttachment
        {
            get
            {
                if ((this._MessageAttachment == null))
                {
                    this._MessageAttachment = base.CreateQuery<MessageAttachment>("MessageAttachment");
                }
                return this._MessageAttachment;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<MessageAttachment> _MessageAttachment;
        /// <summary>
        /// There are no comments for Order in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<Order> Order
        {
            get
            {
                if ((this._Order == null))
                {
                    this._Order = base.CreateQuery<Order>("Order");
                }
                return this._Order;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Order> _Order;
        /// <summary>
        /// There are no comments for OrderLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<OrderLine> OrderLine
        {
            get
            {
                if ((this._OrderLine == null))
                {
                    this._OrderLine = base.CreateQuery<OrderLine>("OrderLine");
                }
                return this._OrderLine;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<OrderLine> _OrderLine;
        /// <summary>
        /// There are no comments for Product in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<Product> Product
        {
            get
            {
                if ((this._Product == null))
                {
                    this._Product = base.CreateQuery<Product>("Product");
                }
                return this._Product;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Product> _Product;
        /// <summary>
        /// There are no comments for ProductDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<ProductDetail> ProductDetail
        {
            get
            {
                if ((this._ProductDetail == null))
                {
                    this._ProductDetail = base.CreateQuery<ProductDetail>("ProductDetail");
                }
                return this._ProductDetail;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<ProductDetail> _ProductDetail;
        /// <summary>
        /// There are no comments for ProductReview in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<ProductReview> ProductReview
        {
            get
            {
                if ((this._ProductReview == null))
                {
                    this._ProductReview = base.CreateQuery<ProductReview>("ProductReview");
                }
                return this._ProductReview;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<ProductReview> _ProductReview;
        /// <summary>
        /// There are no comments for ProductPhoto in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<ProductPhoto> ProductPhoto
        {
            get
            {
                if ((this._ProductPhoto == null))
                {
                    this._ProductPhoto = base.CreateQuery<ProductPhoto>("ProductPhoto");
                }
                return this._ProductPhoto;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<ProductPhoto> _ProductPhoto;
        /// <summary>
        /// There are no comments for CustomerInfo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<CustomerInfo> CustomerInfo
        {
            get
            {
                if ((this._CustomerInfo == null))
                {
                    this._CustomerInfo = base.CreateQuery<CustomerInfo>("CustomerInfo");
                }
                return this._CustomerInfo;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<CustomerInfo> _CustomerInfo;
        /// <summary>
        /// There are no comments for Computer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<Computer> Computer
        {
            get
            {
                if ((this._Computer == null))
                {
                    this._Computer = base.CreateQuery<Computer>("Computer");
                }
                return this._Computer;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Computer> _Computer;
        /// <summary>
        /// There are no comments for ComputerDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<ComputerDetail> ComputerDetail
        {
            get
            {
                if ((this._ComputerDetail == null))
                {
                    this._ComputerDetail = base.CreateQuery<ComputerDetail>("ComputerDetail");
                }
                return this._ComputerDetail;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<ComputerDetail> _ComputerDetail;
        /// <summary>
        /// There are no comments for Driver in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<Driver> Driver
        {
            get
            {
                if ((this._Driver == null))
                {
                    this._Driver = base.CreateQuery<Driver>("Driver");
                }
                return this._Driver;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Driver> _Driver;
        /// <summary>
        /// There are no comments for License in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<License> License
        {
            get
            {
                if ((this._License == null))
                {
                    this._License = base.CreateQuery<License>("License");
                }
                return this._License;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<License> _License;
        /// <summary>
        /// There are no comments for MappedEntityType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<MappedEntityType> MappedEntityType
        {
            get
            {
                if ((this._MappedEntityType == null))
                {
                    this._MappedEntityType = base.CreateQuery<MappedEntityType>("MappedEntityType");
                }
                return this._MappedEntityType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<MappedEntityType> _MappedEntityType;
        /// <summary>
        /// There are no comments for Car in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<Car> Car
        {
            get
            {
                if ((this._Car == null))
                {
                    this._Car = base.CreateQuery<Car>("Car");
                }
                return this._Car;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Car> _Car;
        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<Person> Person
        {
            get
            {
                if ((this._Person == null))
                {
                    this._Person = base.CreateQuery<Person>("Person");
                }
                return this._Person;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Person> _Person;
        /// <summary>
        /// There are no comments for PersonMetadata in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceQuery<PersonMetadata> PersonMetadata
        {
            get
            {
                if ((this._PersonMetadata == null))
                {
                    this._PersonMetadata = base.CreateQuery<PersonMetadata>("PersonMetadata");
                }
                return this._PersonMetadata;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<PersonMetadata> _PersonMetadata;
        /// <summary>
        /// There are no comments for AllGeoTypesSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToAllGeoTypesSet(AllSpatialTypes allSpatialTypes)
        {
            base.AddObject("AllGeoTypesSet", allSpatialTypes);
        }
        /// <summary>
        /// There are no comments for AllGeoCollectionTypesSet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToAllGeoCollectionTypesSet(AllSpatialCollectionTypes allSpatialCollectionTypes)
        {
            base.AddObject("AllGeoCollectionTypesSet", allSpatialCollectionTypes);
        }
        /// <summary>
        /// There are no comments for Customer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToCustomer(Customer customer)
        {
            base.AddObject("Customer", customer);
        }
        /// <summary>
        /// There are no comments for Login in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToLogin(Login login)
        {
            base.AddObject("Login", login);
        }
        /// <summary>
        /// There are no comments for RSAToken in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToRSAToken(RSAToken rSAToken)
        {
            base.AddObject("RSAToken", rSAToken);
        }
        /// <summary>
        /// There are no comments for PageView in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToPageView(PageView pageView)
        {
            base.AddObject("PageView", pageView);
        }
        /// <summary>
        /// There are no comments for LastLogin in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToLastLogin(LastLogin lastLogin)
        {
            base.AddObject("LastLogin", lastLogin);
        }
        /// <summary>
        /// There are no comments for Message in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToMessage(Message message)
        {
            base.AddObject("Message", message);
        }
        /// <summary>
        /// There are no comments for MessageAttachment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToMessageAttachment(MessageAttachment messageAttachment)
        {
            base.AddObject("MessageAttachment", messageAttachment);
        }
        /// <summary>
        /// There are no comments for Order in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToOrder(Order order)
        {
            base.AddObject("Order", order);
        }
        /// <summary>
        /// There are no comments for OrderLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToOrderLine(OrderLine orderLine)
        {
            base.AddObject("OrderLine", orderLine);
        }
        /// <summary>
        /// There are no comments for Product in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToProduct(Product product)
        {
            base.AddObject("Product", product);
        }
        /// <summary>
        /// There are no comments for ProductDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToProductDetail(ProductDetail productDetail)
        {
            base.AddObject("ProductDetail", productDetail);
        }
        /// <summary>
        /// There are no comments for ProductReview in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToProductReview(ProductReview productReview)
        {
            base.AddObject("ProductReview", productReview);
        }
        /// <summary>
        /// There are no comments for ProductPhoto in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToProductPhoto(ProductPhoto productPhoto)
        {
            base.AddObject("ProductPhoto", productPhoto);
        }
        /// <summary>
        /// There are no comments for CustomerInfo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToCustomerInfo(CustomerInfo customerInfo)
        {
            base.AddObject("CustomerInfo", customerInfo);
        }
        /// <summary>
        /// There are no comments for Computer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToComputer(Computer computer)
        {
            base.AddObject("Computer", computer);
        }
        /// <summary>
        /// There are no comments for ComputerDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToComputerDetail(ComputerDetail computerDetail)
        {
            base.AddObject("ComputerDetail", computerDetail);
        }
        /// <summary>
        /// There are no comments for Driver in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToDriver(Driver driver)
        {
            base.AddObject("Driver", driver);
        }
        /// <summary>
        /// There are no comments for License in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToLicense(License license)
        {
            base.AddObject("License", license);
        }
        /// <summary>
        /// There are no comments for MappedEntityType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToMappedEntityType(MappedEntityType mappedEntityType)
        {
            base.AddObject("MappedEntityType", mappedEntityType);
        }
        /// <summary>
        /// There are no comments for Car in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToCar(Car car)
        {
            base.AddObject("Car", car);
        }
        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToPerson(Person person)
        {
            base.AddObject("Person", person);
        }
        /// <summary>
        /// There are no comments for PersonMetadata in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public void AddToPersonMetadata(PersonMetadata personMetadata)
        {
            base.AddObject("PersonMetadata", personMetadata);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
            private const string Edmx = @"<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices m:DataServiceVersion=""4.0"" m:MaxDataServiceVersion=""4.0"" xmlns:m=""http://docs.oasis-open.org/odata/ns/metadata"">
    <Schema Namespace=""Microsoft.Test.OData.Services.AstoriaDefaultService"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""AllSpatialTypes"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Geog"" Type=""Edm.Geography"" SRID=""Variable"" />
        <Property Name=""GeogPoint"" Type=""Edm.GeographyPoint"" SRID=""Variable"" />
        <Property Name=""GeogLine"" Type=""Edm.GeographyLineString"" SRID=""Variable"" />
        <Property Name=""GeogPolygon"" Type=""Edm.GeographyPolygon"" SRID=""Variable"" />
        <Property Name=""GeogCollection"" Type=""Edm.GeographyCollection"" SRID=""Variable"" />
        <Property Name=""GeogMultiPoint"" Type=""Edm.GeographyMultiPoint"" SRID=""Variable"" />
        <Property Name=""GeogMultiLine"" Type=""Edm.GeographyMultiLineString"" SRID=""Variable"" />
        <Property Name=""GeogMultiPolygon"" Type=""Edm.GeographyMultiPolygon"" SRID=""Variable"" />
        <Property Name=""Geom"" Type=""Edm.Geometry"" SRID=""Variable"" />
        <Property Name=""GeomPoint"" Type=""Edm.GeometryPoint"" SRID=""Variable"" />
        <Property Name=""GeomLine"" Type=""Edm.GeometryLineString"" SRID=""Variable"" />
        <Property Name=""GeomPolygon"" Type=""Edm.GeometryPolygon"" SRID=""Variable"" />
        <Property Name=""GeomCollection"" Type=""Edm.GeometryCollection"" SRID=""Variable"" />
        <Property Name=""GeomMultiPoint"" Type=""Edm.GeometryMultiPoint"" SRID=""Variable"" />
        <Property Name=""GeomMultiLine"" Type=""Edm.GeometryMultiLineString"" SRID=""Variable"" />
        <Property Name=""GeomMultiPolygon"" Type=""Edm.GeometryMultiPolygon"" SRID=""Variable"" />
      </EntityType>
      <EntityType Name=""AllSpatialCollectionTypes"" Abstract=""true"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
      </EntityType>
      <EntityType Name=""Customer"">
        <Key>
          <PropertyRef Name=""CustomerId"" />
        </Key>
        <Property Name=""Thumbnail"" Type=""Edm.Stream"" Nullable=""false"" />
        <Property Name=""Video"" Type=""Edm.Stream"" Nullable=""false"" />
        <Property Name=""CustomerId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Name"" Type=""Edm.String"" />
        <Property Name=""PrimaryContactInfo"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.ContactDetails"" />
        <Property Name=""BackupContactInfo"" Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.ContactDetails)"" Nullable=""false"" />
        <Property Name=""Auditing"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.AuditInfo"" />
        <NavigationProperty Name=""Orders"" Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.Order)"" Partner=""Customer"" />
        <NavigationProperty Name=""Logins"" Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.Login)"" Partner=""Customer"" />
        <NavigationProperty Name=""Husband"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Customer"" Partner=""Husband"" />
        <NavigationProperty Name=""Wife"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Customer"" Partner=""Wife"" />
        <NavigationProperty Name=""Info"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.CustomerInfo"" />
      </EntityType>
      <EntityType Name=""Login"">
        <Key>
          <PropertyRef Name=""Username"" />
        </Key>
        <Property Name=""Username"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""CustomerId"" Type=""Edm.Int32"" Nullable=""false"" />
        <NavigationProperty Name=""Customer"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Customer"" Partner=""Logins"" />
        <NavigationProperty Name=""LastLogin"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.LastLogin"" Partner=""Login"" />
        <NavigationProperty Name=""SentMessages"" Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.Message)"" Partner=""Sender"" />
        <NavigationProperty Name=""ReceivedMessages"" Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.Message)"" Partner=""Recipient"" />
        <NavigationProperty Name=""Orders"" Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.Order)"" Partner=""Login"" />
      </EntityType>
      <EntityType Name=""RSAToken"">
        <Key>
          <PropertyRef Name=""Serial"" />
        </Key>
        <Property Name=""Serial"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""Issued"" Type=""Edm.DateTimeOffset"" Nullable=""false"" />
        <NavigationProperty Name=""Login"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Login"" />
      </EntityType>
      <EntityType Name=""PageView"">
        <Key>
          <PropertyRef Name=""PageViewId"" />
        </Key>
        <Property Name=""PageViewId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Username"" Type=""Edm.String"" />
        <Property Name=""Viewed"" Type=""Edm.DateTimeOffset"" Nullable=""false"" />
        <Property Name=""TimeSpentOnPage"" Type=""Edm.Duration"" Nullable=""false"" />
        <Property Name=""PageUrl"" Type=""Edm.String"" />
        <NavigationProperty Name=""Login"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Login"" />
      </EntityType>
      <EntityType Name=""LastLogin"">
        <Key>
          <PropertyRef Name=""Username"" />
        </Key>
        <Property Name=""Username"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""LoggedIn"" Type=""Edm.DateTimeOffset"" Nullable=""false"" />
        <Property Name=""LoggedOut"" Type=""Edm.DateTimeOffset"" />
        <Property Name=""Duration"" Type=""Edm.Duration"" Nullable=""false"" />
        <NavigationProperty Name=""Login"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Login"" Partner=""LastLogin"" />
      </EntityType>
      <EntityType Name=""Message"">
        <Key>
          <PropertyRef Name=""FromUsername"" />
          <PropertyRef Name=""MessageId"" />
        </Key>
        <Property Name=""MessageId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""FromUsername"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""ToUsername"" Type=""Edm.String"" />
        <Property Name=""Sent"" Type=""Edm.DateTimeOffset"" Nullable=""false"" />
        <Property Name=""Subject"" Type=""Edm.String"" />
        <Property Name=""Body"" Type=""Edm.String"" />
        <Property Name=""IsRead"" Type=""Edm.Boolean"" Nullable=""false"" />
        <NavigationProperty Name=""Sender"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Login"" Partner=""SentMessages"" />
        <NavigationProperty Name=""Recipient"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Login"" Partner=""ReceivedMessages"" />
        <NavigationProperty Name=""Attachments"" Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.MessageAttachment)"" />
      </EntityType>
      <EntityType Name=""MessageAttachment"">
        <Key>
          <PropertyRef Name=""AttachmentId"" />
        </Key>
        <Property Name=""AttachmentId"" Type=""Edm.Guid"" Nullable=""false"" />
        <Property Name=""Attachment"" Type=""Edm.Binary"" />
      </EntityType>
      <EntityType Name=""Order"">
        <Key>
          <PropertyRef Name=""OrderId"" />
        </Key>
        <Property Name=""OrderId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""CustomerId"" Type=""Edm.Int32"" />
        <Property Name=""Concurrency"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.ConcurrencyInfo"" />
        <NavigationProperty Name=""Login"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Login"" Partner=""Orders"" />
        <NavigationProperty Name=""Customer"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Customer"" Partner=""Orders"" />
      </EntityType>
      <EntityType Name=""OrderLine"">
        <Key>
          <PropertyRef Name=""OrderId"" />
          <PropertyRef Name=""ProductId"" />
        </Key>
        <Property Name=""OrderLineStream"" Type=""Edm.Stream"" Nullable=""false"" />
        <Property Name=""OrderId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""ProductId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Quantity"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""ConcurrencyToken"" Type=""Edm.String"" />
        <NavigationProperty Name=""Order"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Order"" />
        <NavigationProperty Name=""Product"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Product"" />
      </EntityType>
      <EntityType Name=""Product"">
        <Key>
          <PropertyRef Name=""ProductId"" />
        </Key>
        <Property Name=""Picture"" Type=""Edm.Stream"" Nullable=""false"" />
        <Property Name=""ProductId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Description"" Type=""Edm.String"" />
        <Property Name=""Dimensions"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Dimensions"" />
        <Property Name=""BaseConcurrency"" Type=""Edm.String"" />
        <Property Name=""ComplexConcurrency"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.ConcurrencyInfo"" />
        <Property Name=""NestedComplexConcurrency"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.AuditInfo"" />
        <NavigationProperty Name=""RelatedProducts"" Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.Product)"" Partner=""RelatedProducts"" />
        <NavigationProperty Name=""Detail"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.ProductDetail"" Partner=""Product"" />
        <NavigationProperty Name=""Reviews"" Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.ProductReview)"" Partner=""Product"" />
        <NavigationProperty Name=""Photos"" Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.ProductPhoto)"" />
      </EntityType>
      <EntityType Name=""ProductDetail"">
        <Key>
          <PropertyRef Name=""ProductId"" />
        </Key>
        <Property Name=""ProductId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Details"" Type=""Edm.String"" />
        <NavigationProperty Name=""Product"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Product"" Partner=""Detail"" />
      </EntityType>
      <EntityType Name=""ProductReview"">
        <Key>
          <PropertyRef Name=""ProductId"" />
          <PropertyRef Name=""ReviewId"" />
          <PropertyRef Name=""RevisionId"" />
        </Key>
        <Property Name=""ProductId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""ReviewId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Review"" Type=""Edm.String"" />
        <Property Name=""RevisionId"" Type=""Edm.String"" Nullable=""false"" />
        <NavigationProperty Name=""Product"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Product"" Partner=""Reviews"" />
      </EntityType>
      <EntityType Name=""ProductPhoto"">
        <Key>
          <PropertyRef Name=""PhotoId"" />
          <PropertyRef Name=""ProductId"" />
        </Key>
        <Property Name=""ProductId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""PhotoId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Photo"" Type=""Edm.Binary"" />
      </EntityType>
      <EntityType Name=""CustomerInfo"" m:HasStream=""true"">
        <Key>
          <PropertyRef Name=""CustomerInfoId"" />
        </Key>
        <Property Name=""CustomerInfoId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Information"" Type=""Edm.String"" />
      </EntityType>
      <EntityType Name=""Computer"">
        <Key>
          <PropertyRef Name=""ComputerId"" />
        </Key>
        <Property Name=""ComputerId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Name"" Type=""Edm.String"" />
        <NavigationProperty Name=""ComputerDetail"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.ComputerDetail"" Partner=""Computer"" />
      </EntityType>
      <EntityType Name=""ComputerDetail"">
        <Key>
          <PropertyRef Name=""ComputerDetailId"" />
        </Key>
        <Property Name=""ComputerDetailId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Manufacturer"" Type=""Edm.String"" />
        <Property Name=""Model"" Type=""Edm.String"" />
        <Property Name=""Serial"" Type=""Edm.String"" />
        <Property Name=""SpecificationsBag"" Type=""Collection(Edm.String)"" Nullable=""false"" />
        <Property Name=""PurchaseDate"" Type=""Edm.DateTimeOffset"" Nullable=""false"" />
        <Property Name=""Dimensions"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Dimensions"" />
        <NavigationProperty Name=""Computer"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Computer"" Partner=""ComputerDetail"" />
      </EntityType>
      <EntityType Name=""Driver"">
        <Key>
          <PropertyRef Name=""Name"" />
        </Key>
        <Property Name=""Name"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""BirthDate"" Type=""Edm.DateTimeOffset"" Nullable=""false"" />
        <NavigationProperty Name=""License"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.License"" Partner=""Driver"" />
      </EntityType>
      <EntityType Name=""License"">
        <Key>
          <PropertyRef Name=""Name"" />
        </Key>
        <Property Name=""Name"" Type=""Edm.String"" Nullable=""false"" />
        <Property Name=""LicenseNumber"" Type=""Edm.String"" />
        <Property Name=""LicenseClass"" Type=""Edm.String"" />
        <Property Name=""Restrictions"" Type=""Edm.String"" />
        <Property Name=""ExpirationDate"" Type=""Edm.DateTimeOffset"" Nullable=""false"" />
        <NavigationProperty Name=""Driver"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Driver"" Partner=""License"" />
      </EntityType>
      <EntityType Name=""MappedEntityType"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Href"" Type=""Edm.String"" />
        <Property Name=""Title"" Type=""Edm.String"" />
        <Property Name=""HrefLang"" Type=""Edm.String"" />
        <Property Name=""Type"" Type=""Edm.String"" />
        <Property Name=""Length"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""BagOfPrimitiveToLinks"" Type=""Collection(Edm.String)"" Nullable=""false"" />
        <Property Name=""Logo"" Type=""Edm.Binary"" />
        <Property Name=""BagOfDecimals"" Type=""Collection(Edm.Decimal)"" Nullable=""false"" />
        <Property Name=""BagOfDoubles"" Type=""Collection(Edm.Double)"" Nullable=""false"" />
        <Property Name=""BagOfSingles"" Type=""Collection(Edm.Single)"" Nullable=""false"" />
        <Property Name=""BagOfBytes"" Type=""Collection(Edm.Byte)"" Nullable=""false"" />
        <Property Name=""BagOfInt16s"" Type=""Collection(Edm.Int16)"" Nullable=""false"" />
        <Property Name=""BagOfInt32s"" Type=""Collection(Edm.Int32)"" Nullable=""false"" />
        <Property Name=""BagOfInt64s"" Type=""Collection(Edm.Int64)"" Nullable=""false"" />
        <Property Name=""BagOfGuids"" Type=""Collection(Edm.Guid)"" Nullable=""false"" />
        <Property Name=""BagOfDateTimeOffset"" Type=""Collection(Edm.DateTimeOffset)"" Nullable=""false"" />
        <Property Name=""BagOfComplexToCategories"" Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.ComplexToCategory)"" Nullable=""false"" />
        <Property Name=""ComplexPhone"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Phone"" />
        <Property Name=""ComplexContactDetails"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.ContactDetails"" />
      </EntityType>
      <EntityType Name=""Car"" m:HasStream=""true"">
        <Key>
          <PropertyRef Name=""VIN"" />
        </Key>
        <Property Name=""Photo"" Type=""Edm.Stream"" Nullable=""false"" />
        <Property Name=""Video"" Type=""Edm.Stream"" Nullable=""false"" />
        <Property Name=""VIN"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Description"" Type=""Edm.String"" />
      </EntityType>
      <EntityType Name=""Person"">
        <Key>
          <PropertyRef Name=""PersonId"" />
        </Key>
        <Property Name=""PersonId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Name"" Type=""Edm.String"" />
        <NavigationProperty Name=""PersonMetadata"" Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.PersonMetadata)"" Partner=""Person"" />
      </EntityType>
      <EntityType Name=""PersonMetadata"">
        <Key>
          <PropertyRef Name=""PersonMetadataId"" />
        </Key>
        <Property Name=""PersonMetadataId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""PersonId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""PropertyName"" Type=""Edm.String"" />
        <Property Name=""PropertyValue"" Type=""Edm.String"" />
        <NavigationProperty Name=""Person"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Person"" Partner=""PersonMetadata"" />
      </EntityType>
      <ComplexType Name=""ContactDetails"">
        <Property Name=""EmailBag"" Type=""Collection(Edm.String)"" Nullable=""false"" />
        <Property Name=""AlternativeNames"" Type=""Collection(Edm.String)"" Nullable=""false"" />
        <Property Name=""ContactAlias"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Aliases"" />
        <Property Name=""HomePhone"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Phone"" />
        <Property Name=""WorkPhone"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Phone"" />
        <Property Name=""MobilePhoneBag"" Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.Phone)"" Nullable=""false"" />
      </ComplexType>
      <ComplexType Name=""AuditInfo"">
        <Property Name=""ModifiedDate"" Type=""Edm.DateTimeOffset"" Nullable=""false"" />
        <Property Name=""ModifiedBy"" Type=""Edm.String"" />
        <Property Name=""Concurrency"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.ConcurrencyInfo"" />
      </ComplexType>
      <ComplexType Name=""ConcurrencyInfo"">
        <Property Name=""Token"" Type=""Edm.String"" />
        <Property Name=""QueriedDateTime"" Type=""Edm.DateTimeOffset"" />
      </ComplexType>
      <ComplexType Name=""Dimensions"">
        <Property Name=""Width"" Type=""Edm.Decimal"" Nullable=""false"" />
        <Property Name=""Height"" Type=""Edm.Decimal"" Nullable=""false"" />
        <Property Name=""Depth"" Type=""Edm.Decimal"" Nullable=""false"" />
      </ComplexType>
      <ComplexType Name=""ComplexToCategory"">
        <Property Name=""Term"" Type=""Edm.String"" />
        <Property Name=""Scheme"" Type=""Edm.String"" />
        <Property Name=""Label"" Type=""Edm.String"" />
      </ComplexType>
      <ComplexType Name=""Phone"">
        <Property Name=""PhoneNumber"" Type=""Edm.String"" />
        <Property Name=""Extension"" Type=""Edm.String"" />
      </ComplexType>
      <ComplexType Name=""Aliases"">
        <Property Name=""AlternativeNames"" Type=""Collection(Edm.String)"" Nullable=""false"" />
      </ComplexType>
      <EntityType Name=""AllSpatialCollectionTypes_Simple"" BaseType=""Microsoft.Test.OData.Services.AstoriaDefaultService.AllSpatialCollectionTypes"">
        <Property Name=""ManyGeogPoint"" Type=""Collection(Edm.GeographyPoint)"" Nullable=""false"" SRID=""Variable"" />
        <Property Name=""ManyGeogLine"" Type=""Collection(Edm.GeographyLineString)"" Nullable=""false"" SRID=""Variable"" />
        <Property Name=""ManyGeogPolygon"" Type=""Collection(Edm.GeographyPolygon)"" Nullable=""false"" SRID=""Variable"" />
        <Property Name=""ManyGeomPoint"" Type=""Collection(Edm.GeometryPoint)"" Nullable=""false"" SRID=""Variable"" />
        <Property Name=""ManyGeomLine"" Type=""Collection(Edm.GeometryLineString)"" Nullable=""false"" SRID=""Variable"" />
        <Property Name=""ManyGeomPolygon"" Type=""Collection(Edm.GeometryPolygon)"" Nullable=""false"" SRID=""Variable"" />
      </EntityType>
      <EntityType Name=""ProductPageView"" BaseType=""Microsoft.Test.OData.Services.AstoriaDefaultService.PageView"">
        <Property Name=""ProductId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""ConcurrencyToken"" Type=""Edm.String"" />
      </EntityType>
      <EntityType Name=""BackOrderLine"" BaseType=""Microsoft.Test.OData.Services.AstoriaDefaultService.OrderLine"" />
      <EntityType Name=""BackOrderLine2"" BaseType=""Microsoft.Test.OData.Services.AstoriaDefaultService.BackOrderLine"" />
      <EntityType Name=""DiscontinuedProduct"" BaseType=""Microsoft.Test.OData.Services.AstoriaDefaultService.Product"">
        <Property Name=""Discontinued"" Type=""Edm.DateTimeOffset"" Nullable=""false"" />
        <Property Name=""ReplacementProductId"" Type=""Edm.Int32"" />
        <Property Name=""DiscontinuedPhone"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Phone"" />
        <Property Name=""ChildConcurrencyToken"" Type=""Edm.String"" />
      </EntityType>
      <EntityType Name=""Contractor"" BaseType=""Microsoft.Test.OData.Services.AstoriaDefaultService.Person"">
        <Property Name=""ContratorCompanyId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""BillingRate"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""TeamContactPersonId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""JobDescription"" Type=""Edm.String"" />
      </EntityType>
      <EntityType Name=""Employee"" BaseType=""Microsoft.Test.OData.Services.AstoriaDefaultService.Person"">
        <Property Name=""ManagersPersonId"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Salary"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Title"" Type=""Edm.String"" />
        <NavigationProperty Name=""Manager"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Employee"" Partner=""Manager"" />
      </EntityType>
      <EntityType Name=""SpecialEmployee"" BaseType=""Microsoft.Test.OData.Services.AstoriaDefaultService.Employee"">
        <Property Name=""CarsVIN"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Bonus"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""IsFullyVested"" Type=""Edm.Boolean"" Nullable=""false"" />
        <NavigationProperty Name=""Car"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Car"" />
      </EntityType>
      <ComplexType Name=""ComplexWithAllPrimitiveTypes"">
        <Property Name=""Binary"" Type=""Edm.Binary"" />
        <Property Name=""Boolean"" Type=""Edm.Boolean"" Nullable=""false"" />
        <Property Name=""Byte"" Type=""Edm.Byte"" Nullable=""false"" />
        <Property Name=""DateTimeOffset"" Type=""Edm.DateTimeOffset"" Nullable=""false"" />
        <Property Name=""Decimal"" Type=""Edm.Decimal"" Nullable=""false"" />
        <Property Name=""Double"" Type=""Edm.Double"" Nullable=""false"" />
        <Property Name=""Int16"" Type=""Edm.Int16"" Nullable=""false"" />
        <Property Name=""Int32"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Int64"" Type=""Edm.Int64"" Nullable=""false"" />
        <Property Name=""SByte"" Type=""Edm.SByte"" Nullable=""false"" />
        <Property Name=""String"" Type=""Edm.String"" />
        <Property Name=""Single"" Type=""Edm.Single"" Nullable=""false"" />
        <Property Name=""GeographyPoint"" Type=""Edm.GeographyPoint"" SRID=""Variable"" />
        <Property Name=""GeometryPoint"" Type=""Edm.GeometryPoint"" SRID=""Variable"" />
      </ComplexType>
      <Function Name=""GetPrimitiveString"">
        <ReturnType Type=""Edm.String"" />
      </Function>
      <Function Name=""GetSpecificCustomer"">
        <Parameter Name=""Name"" Type=""Edm.String"" />
        <ReturnType Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.Customer)"" />
      </Function>
      <Function Name=""GetCustomerCount"" IsComposable=""true"">
        <ReturnType Type=""Edm.Int32"" Nullable=""false"" />
      </Function>
      <Function Name=""GetArgumentPlusOne"" IsComposable=""true"">
        <Parameter Name=""arg1"" Type=""Edm.Int32"" Nullable=""false"" />
        <ReturnType Type=""Edm.Int32"" Nullable=""false"" />
      </Function>
      <Function Name=""EntityProjectionReturnsCollectionOfComplexTypes"">
        <ReturnType Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.ContactDetails)"" />
      </Function>
      <Action Name=""ResetDataSource"" />
      <Function Name=""InStreamErrorGetCustomer"">
        <ReturnType Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.Customer)"" />
      </Function>
      <Action Name=""IncreaseSalaries"" IsBound=""true"" m:IsAlwaysBindable=""true"">
        <Parameter Name=""employees"" Type=""Collection(Microsoft.Test.OData.Services.AstoriaDefaultService.Employee)"" />
        <Parameter Name=""n"" Type=""Edm.Int32"" Nullable=""false"" />
      </Action>
      <Action Name=""Sack"" IsBound=""true"" m:IsAlwaysBindable=""true"">
        <Parameter Name=""employee"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Employee"" />
      </Action>
      <Action Name=""GetComputer"" IsBound=""true"" EntitySetPath=""computer"" m:IsAlwaysBindable=""true"">
        <Parameter Name=""computer"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Computer"" />
        <ReturnType Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Computer"" />
      </Action>
      <Action Name=""ChangeCustomerAuditInfo"" IsBound=""true"" m:IsAlwaysBindable=""true"">
        <Parameter Name=""customer"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.Customer"" />
        <Parameter Name=""auditInfo"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.AuditInfo"" />
      </Action>
      <Action Name=""ResetComputerDetailsSpecifications"" IsBound=""true"" m:IsAlwaysBindable=""true"">
        <Parameter Name=""computerDetail"" Type=""Microsoft.Test.OData.Services.AstoriaDefaultService.ComputerDetail"" />
        <Parameter Name=""specifications"" Type=""Collection(Edm.String)"" Nullable=""false"" />
        <Parameter Name=""purchaseTime"" Type=""Edm.DateTimeOffset"" Nullable=""false"" />
      </Action>
      <EntityContainer Name=""DefaultContainer"">
        <EntitySet Name=""AllGeoTypesSet"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.AllSpatialTypes"" />
        <EntitySet Name=""AllGeoCollectionTypesSet"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.AllSpatialCollectionTypes"" />
        <EntitySet Name=""Customer"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.Customer"">
          <NavigationPropertyBinding Path=""Orders"" Target=""Order"" />
          <NavigationPropertyBinding Path=""Logins"" Target=""Login"" />
          <NavigationPropertyBinding Path=""Husband"" Target=""Customer"" />
          <NavigationPropertyBinding Path=""Wife"" Target=""Customer"" />
          <NavigationPropertyBinding Path=""Info"" Target=""CustomerInfo"" />
        </EntitySet>
        <EntitySet Name=""Login"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.Login"">
          <NavigationPropertyBinding Path=""Customer"" Target=""Customer"" />
          <NavigationPropertyBinding Path=""LastLogin"" Target=""LastLogin"" />
          <NavigationPropertyBinding Path=""SentMessages"" Target=""Message"" />
          <NavigationPropertyBinding Path=""ReceivedMessages"" Target=""Message"" />
          <NavigationPropertyBinding Path=""Orders"" Target=""Order"" />
        </EntitySet>
        <EntitySet Name=""RSAToken"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.RSAToken"">
          <NavigationPropertyBinding Path=""Login"" Target=""Login"" />
        </EntitySet>
        <EntitySet Name=""PageView"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.PageView"">
          <NavigationPropertyBinding Path=""Login"" Target=""Login"" />
        </EntitySet>
        <EntitySet Name=""LastLogin"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.LastLogin"">
          <NavigationPropertyBinding Path=""Login"" Target=""Login"" />
        </EntitySet>
        <EntitySet Name=""Message"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.Message"">
          <NavigationPropertyBinding Path=""Sender"" Target=""Login"" />
          <NavigationPropertyBinding Path=""Recipient"" Target=""Login"" />
          <NavigationPropertyBinding Path=""Attachments"" Target=""MessageAttachment"" />
        </EntitySet>
        <EntitySet Name=""MessageAttachment"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.MessageAttachment"" />
        <EntitySet Name=""Order"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.Order"">
          <NavigationPropertyBinding Path=""Customer"" Target=""Customer"" />
          <NavigationPropertyBinding Path=""Login"" Target=""Login"" />
        </EntitySet>
        <EntitySet Name=""OrderLine"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.OrderLine"">
          <NavigationPropertyBinding Path=""Order"" Target=""Order"" />
          <NavigationPropertyBinding Path=""Product"" Target=""Product"" />
        </EntitySet>
        <EntitySet Name=""Product"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.Product"">
          <NavigationPropertyBinding Path=""RelatedProducts"" Target=""Product"" />
          <NavigationPropertyBinding Path=""Detail"" Target=""ProductDetail"" />
          <NavigationPropertyBinding Path=""Reviews"" Target=""ProductReview"" />
          <NavigationPropertyBinding Path=""Photos"" Target=""ProductPhoto"" />
        </EntitySet>
        <EntitySet Name=""ProductDetail"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.ProductDetail"">
          <NavigationPropertyBinding Path=""Product"" Target=""Product"" />
        </EntitySet>
        <EntitySet Name=""ProductReview"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.ProductReview"">
          <NavigationPropertyBinding Path=""Product"" Target=""Product"" />
        </EntitySet>
        <EntitySet Name=""ProductPhoto"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.ProductPhoto"" />
        <EntitySet Name=""CustomerInfo"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.CustomerInfo"" />
        <EntitySet Name=""Computer"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.Computer"">
          <NavigationPropertyBinding Path=""ComputerDetail"" Target=""ComputerDetail"" />
        </EntitySet>
        <EntitySet Name=""ComputerDetail"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.ComputerDetail"">
          <NavigationPropertyBinding Path=""Computer"" Target=""Computer"" />
        </EntitySet>
        <EntitySet Name=""Driver"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.Driver"">
          <NavigationPropertyBinding Path=""License"" Target=""License"" />
        </EntitySet>
        <EntitySet Name=""License"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.License"">
          <NavigationPropertyBinding Path=""Driver"" Target=""Driver"" />
        </EntitySet>
        <EntitySet Name=""MappedEntityType"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.MappedEntityType"" />
        <EntitySet Name=""Car"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.Car"" />
        <EntitySet Name=""Person"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.Person"">
          <NavigationPropertyBinding Path=""Microsoft.Test.OData.Services.AstoriaDefaultService.Employee/Manager"" Target=""Person"" />
          <NavigationPropertyBinding Path=""Microsoft.Test.OData.Services.AstoriaDefaultService.SpecialEmployee/Car"" Target=""Car"" />
          <NavigationPropertyBinding Path=""PersonMetadata"" Target=""PersonMetadata"" />
        </EntitySet>
        <EntitySet Name=""PersonMetadata"" EntityType=""Microsoft.Test.OData.Services.AstoriaDefaultService.PersonMetadata"">
          <NavigationPropertyBinding Path=""Person"" Target=""Person"" />
        </EntitySet>
        <FunctionImport Name=""GetPrimitiveString"" Function=""Microsoft.Test.OData.Services.AstoriaDefaultService.GetPrimitiveString"" IncludeInServiceDocument=""true"" />
        <FunctionImport Name=""GetSpecificCustomer"" Function=""Microsoft.Test.OData.Services.AstoriaDefaultService.GetSpecificCustomer"" EntitySet=""Customer"" IncludeInServiceDocument=""true"" />
        <FunctionImport Name=""GetCustomerCount"" Function=""Microsoft.Test.OData.Services.AstoriaDefaultService.GetCustomerCount"" IncludeInServiceDocument=""true"" />
        <FunctionImport Name=""GetArgumentPlusOne"" Function=""Microsoft.Test.OData.Services.AstoriaDefaultService.GetArgumentPlusOne"" IncludeInServiceDocument=""true"" />
        <FunctionImport Name=""EntityProjectionReturnsCollectionOfComplexTypes"" Function=""Microsoft.Test.OData.Services.AstoriaDefaultService.EntityProjectionReturnsCollectionOfComplexTypes"" IncludeInServiceDocument=""true"" />
        <ActionImport Name=""ResetDataSource"" Action=""Microsoft.Test.OData.Services.AstoriaDefaultService.ResetDataSource"" />
        <FunctionImport Name=""InStreamErrorGetCustomer"" Function=""Microsoft.Test.OData.Services.AstoriaDefaultService.InStreamErrorGetCustomer"" EntitySet=""Customer"" IncludeInServiceDocument=""true"" />
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()
            {
                global::System.Xml.XmlReader reader = CreateXmlReader(Edmx);
                try
                {
                    return global::Microsoft.OData.Edm.Csdl.CsdlReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for AllSpatialTypes in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("Id")]
    [global::Microsoft.OData.Client.EntitySetAttribute("AllGeoTypesSet")]
    public partial class AllSpatialTypes : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AllSpatialTypes object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static AllSpatialTypes CreateAllSpatialTypes(int ID)
        {
            AllSpatialTypes allSpatialTypes = new AllSpatialTypes();
            allSpatialTypes.Id = ID;
            return allSpatialTypes;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Geog in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.Geography Geog
        {
            get
            {
                return this._Geog;
            }
            set
            {
                this.OnGeogChanging(value);
                this._Geog = value;
                this.OnGeogChanged();
                this.OnPropertyChanged("Geog");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.Geography _Geog;
        partial void OnGeogChanging(global::Microsoft.Spatial.Geography value);
        partial void OnGeogChanged();
        /// <summary>
        /// There are no comments for Property GeogPoint in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeographyPoint GeogPoint
        {
            get
            {
                return this._GeogPoint;
            }
            set
            {
                this.OnGeogPointChanging(value);
                this._GeogPoint = value;
                this.OnGeogPointChanged();
                this.OnPropertyChanged("GeogPoint");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeographyPoint _GeogPoint;
        partial void OnGeogPointChanging(global::Microsoft.Spatial.GeographyPoint value);
        partial void OnGeogPointChanged();
        /// <summary>
        /// There are no comments for Property GeogLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeographyLineString GeogLine
        {
            get
            {
                return this._GeogLine;
            }
            set
            {
                this.OnGeogLineChanging(value);
                this._GeogLine = value;
                this.OnGeogLineChanged();
                this.OnPropertyChanged("GeogLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeographyLineString _GeogLine;
        partial void OnGeogLineChanging(global::Microsoft.Spatial.GeographyLineString value);
        partial void OnGeogLineChanged();
        /// <summary>
        /// There are no comments for Property GeogPolygon in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeographyPolygon GeogPolygon
        {
            get
            {
                return this._GeogPolygon;
            }
            set
            {
                this.OnGeogPolygonChanging(value);
                this._GeogPolygon = value;
                this.OnGeogPolygonChanged();
                this.OnPropertyChanged("GeogPolygon");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeographyPolygon _GeogPolygon;
        partial void OnGeogPolygonChanging(global::Microsoft.Spatial.GeographyPolygon value);
        partial void OnGeogPolygonChanged();
        /// <summary>
        /// There are no comments for Property GeogCollection in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeographyCollection GeogCollection
        {
            get
            {
                return this._GeogCollection;
            }
            set
            {
                this.OnGeogCollectionChanging(value);
                this._GeogCollection = value;
                this.OnGeogCollectionChanged();
                this.OnPropertyChanged("GeogCollection");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeographyCollection _GeogCollection;
        partial void OnGeogCollectionChanging(global::Microsoft.Spatial.GeographyCollection value);
        partial void OnGeogCollectionChanged();
        /// <summary>
        /// There are no comments for Property GeogMultiPoint in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeographyMultiPoint GeogMultiPoint
        {
            get
            {
                return this._GeogMultiPoint;
            }
            set
            {
                this.OnGeogMultiPointChanging(value);
                this._GeogMultiPoint = value;
                this.OnGeogMultiPointChanged();
                this.OnPropertyChanged("GeogMultiPoint");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeographyMultiPoint _GeogMultiPoint;
        partial void OnGeogMultiPointChanging(global::Microsoft.Spatial.GeographyMultiPoint value);
        partial void OnGeogMultiPointChanged();
        /// <summary>
        /// There are no comments for Property GeogMultiLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeographyMultiLineString GeogMultiLine
        {
            get
            {
                return this._GeogMultiLine;
            }
            set
            {
                this.OnGeogMultiLineChanging(value);
                this._GeogMultiLine = value;
                this.OnGeogMultiLineChanged();
                this.OnPropertyChanged("GeogMultiLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeographyMultiLineString _GeogMultiLine;
        partial void OnGeogMultiLineChanging(global::Microsoft.Spatial.GeographyMultiLineString value);
        partial void OnGeogMultiLineChanged();
        /// <summary>
        /// There are no comments for Property GeogMultiPolygon in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeographyMultiPolygon GeogMultiPolygon
        {
            get
            {
                return this._GeogMultiPolygon;
            }
            set
            {
                this.OnGeogMultiPolygonChanging(value);
                this._GeogMultiPolygon = value;
                this.OnGeogMultiPolygonChanged();
                this.OnPropertyChanged("GeogMultiPolygon");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeographyMultiPolygon _GeogMultiPolygon;
        partial void OnGeogMultiPolygonChanging(global::Microsoft.Spatial.GeographyMultiPolygon value);
        partial void OnGeogMultiPolygonChanged();
        /// <summary>
        /// There are no comments for Property Geom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.Geometry Geom
        {
            get
            {
                return this._Geom;
            }
            set
            {
                this.OnGeomChanging(value);
                this._Geom = value;
                this.OnGeomChanged();
                this.OnPropertyChanged("Geom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.Geometry _Geom;
        partial void OnGeomChanging(global::Microsoft.Spatial.Geometry value);
        partial void OnGeomChanged();
        /// <summary>
        /// There are no comments for Property GeomPoint in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeometryPoint GeomPoint
        {
            get
            {
                return this._GeomPoint;
            }
            set
            {
                this.OnGeomPointChanging(value);
                this._GeomPoint = value;
                this.OnGeomPointChanged();
                this.OnPropertyChanged("GeomPoint");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeometryPoint _GeomPoint;
        partial void OnGeomPointChanging(global::Microsoft.Spatial.GeometryPoint value);
        partial void OnGeomPointChanged();
        /// <summary>
        /// There are no comments for Property GeomLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeometryLineString GeomLine
        {
            get
            {
                return this._GeomLine;
            }
            set
            {
                this.OnGeomLineChanging(value);
                this._GeomLine = value;
                this.OnGeomLineChanged();
                this.OnPropertyChanged("GeomLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeometryLineString _GeomLine;
        partial void OnGeomLineChanging(global::Microsoft.Spatial.GeometryLineString value);
        partial void OnGeomLineChanged();
        /// <summary>
        /// There are no comments for Property GeomPolygon in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeometryPolygon GeomPolygon
        {
            get
            {
                return this._GeomPolygon;
            }
            set
            {
                this.OnGeomPolygonChanging(value);
                this._GeomPolygon = value;
                this.OnGeomPolygonChanged();
                this.OnPropertyChanged("GeomPolygon");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeometryPolygon _GeomPolygon;
        partial void OnGeomPolygonChanging(global::Microsoft.Spatial.GeometryPolygon value);
        partial void OnGeomPolygonChanged();
        /// <summary>
        /// There are no comments for Property GeomCollection in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeometryCollection GeomCollection
        {
            get
            {
                return this._GeomCollection;
            }
            set
            {
                this.OnGeomCollectionChanging(value);
                this._GeomCollection = value;
                this.OnGeomCollectionChanged();
                this.OnPropertyChanged("GeomCollection");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeometryCollection _GeomCollection;
        partial void OnGeomCollectionChanging(global::Microsoft.Spatial.GeometryCollection value);
        partial void OnGeomCollectionChanged();
        /// <summary>
        /// There are no comments for Property GeomMultiPoint in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeometryMultiPoint GeomMultiPoint
        {
            get
            {
                return this._GeomMultiPoint;
            }
            set
            {
                this.OnGeomMultiPointChanging(value);
                this._GeomMultiPoint = value;
                this.OnGeomMultiPointChanged();
                this.OnPropertyChanged("GeomMultiPoint");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeometryMultiPoint _GeomMultiPoint;
        partial void OnGeomMultiPointChanging(global::Microsoft.Spatial.GeometryMultiPoint value);
        partial void OnGeomMultiPointChanged();
        /// <summary>
        /// There are no comments for Property GeomMultiLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeometryMultiLineString GeomMultiLine
        {
            get
            {
                return this._GeomMultiLine;
            }
            set
            {
                this.OnGeomMultiLineChanging(value);
                this._GeomMultiLine = value;
                this.OnGeomMultiLineChanged();
                this.OnPropertyChanged("GeomMultiLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeometryMultiLineString _GeomMultiLine;
        partial void OnGeomMultiLineChanging(global::Microsoft.Spatial.GeometryMultiLineString value);
        partial void OnGeomMultiLineChanged();
        /// <summary>
        /// There are no comments for Property GeomMultiPolygon in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeometryMultiPolygon GeomMultiPolygon
        {
            get
            {
                return this._GeomMultiPolygon;
            }
            set
            {
                this.OnGeomMultiPolygonChanging(value);
                this._GeomMultiPolygon = value;
                this.OnGeomMultiPolygonChanged();
                this.OnPropertyChanged("GeomMultiPolygon");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeometryMultiPolygon _GeomMultiPolygon;
        partial void OnGeomMultiPolygonChanging(global::Microsoft.Spatial.GeometryMultiPolygon value);
        partial void OnGeomMultiPolygonChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for AllSpatialCollectionTypes in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("Id")]
    [global::Microsoft.OData.Client.EntitySetAttribute("AllGeoCollectionTypesSet")]
    public abstract partial class AllSpatialCollectionTypes : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Customer in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CustomerId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("CustomerId")]
    [global::Microsoft.OData.Client.EntitySetAttribute("Customer")]
    public partial class Customer : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="thumbnail">Initial value of Thumbnail.</param>
        /// <param name="video">Initial value of Video.</param>
        /// <param name="customerId">Initial value of CustomerId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static Customer CreateCustomer(global::Microsoft.OData.Client.DataServiceStreamLink thumbnail, global::Microsoft.OData.Client.DataServiceStreamLink video, double customerId)
        {
            Customer customer = new Customer();
            customer.Thumbnail = thumbnail;
            customer.Video = video;
            customer.CustomerId = customerId;
            return customer;
        }
        /// <summary>
        /// There are no comments for Property Thumbnail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceStreamLink Thumbnail
        {
            get
            {
                return this._Thumbnail;
            }
            set
            {
                this.OnThumbnailChanging(value);
                this._Thumbnail = value;
                this.OnThumbnailChanged();
                this.OnPropertyChanged("Thumbnail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceStreamLink _Thumbnail;
        partial void OnThumbnailChanging(global::Microsoft.OData.Client.DataServiceStreamLink value);
        partial void OnThumbnailChanged();
        /// <summary>
        /// There are no comments for Property Video in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceStreamLink Video
        {
            get
            {
                return this._Video;
            }
            set
            {
                this.OnVideoChanging(value);
                this._Video = value;
                this.OnVideoChanged();
                this.OnPropertyChanged("Video");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceStreamLink _Video;
        partial void OnVideoChanging(global::Microsoft.OData.Client.DataServiceStreamLink value);
        partial void OnVideoChanged();
        /// <summary>
        /// There are no comments for Property CustomerId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public double CustomerId
        {
            get
            {
                return this._CustomerId;
            }
            set
            {
                this.OnCustomerIdChanging(value);
                this._CustomerId = value;
                this.OnCustomerIdChanged();
                this.OnPropertyChanged("CustomerId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private double _CustomerId;
        partial void OnCustomerIdChanging(double value);
        partial void OnCustomerIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property PrimaryContactInfo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ContactDetails PrimaryContactInfo
        {
            get
            {
                return this._PrimaryContactInfo;
            }
            set
            {
                this.OnPrimaryContactInfoChanging(value);
                this._PrimaryContactInfo = value;
                this.OnPrimaryContactInfoChanged();
                this.OnPropertyChanged("PrimaryContactInfo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ContactDetails _PrimaryContactInfo;
        partial void OnPrimaryContactInfoChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ContactDetails value);
        partial void OnPrimaryContactInfoChanged();
        /// <summary>
        /// There are no comments for Property BackupContactInfo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ContactDetails> BackupContactInfo
        {
            get
            {
                return this._BackupContactInfo;
            }
            set
            {
                this.OnBackupContactInfoChanging(value);
                this._BackupContactInfo = value;
                this.OnBackupContactInfoChanged();
                this.OnPropertyChanged("BackupContactInfo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ContactDetails> _BackupContactInfo = new global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ContactDetails>();
        partial void OnBackupContactInfoChanging(global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ContactDetails> value);
        partial void OnBackupContactInfoChanged();
        /// <summary>
        /// There are no comments for Property Auditing in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.AuditInfo Auditing
        {
            get
            {
                return this._Auditing;
            }
            set
            {
                this.OnAuditingChanging(value);
                this._Auditing = value;
                this.OnAuditingChanged();
                this.OnPropertyChanged("Auditing");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.AuditInfo _Auditing;
        partial void OnAuditingChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.AuditInfo value);
        partial void OnAuditingChanged();
        /// <summary>
        /// There are no comments for Property Orders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Order> Orders
        {
            get
            {
                return this._Orders;
            }
            set
            {
                this.OnOrdersChanging(value);
                this._Orders = value;
                this.OnOrdersChanged();
                this.OnPropertyChanged("Orders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Order> _Orders = new global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Order>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnOrdersChanging(global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Order> value);
        partial void OnOrdersChanged();
        /// <summary>
        /// There are no comments for Property Logins in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login> Logins
        {
            get
            {
                return this._Logins;
            }
            set
            {
                this.OnLoginsChanging(value);
                this._Logins = value;
                this.OnLoginsChanged();
                this.OnPropertyChanged("Logins");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login> _Logins = new global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnLoginsChanging(global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login> value);
        partial void OnLoginsChanged();
        /// <summary>
        /// There are no comments for Property Husband in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Customer Husband
        {
            get
            {
                return this._Husband;
            }
            set
            {
                this.OnHusbandChanging(value);
                this._Husband = value;
                this.OnHusbandChanged();
                this.OnPropertyChanged("Husband");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Customer _Husband;
        partial void OnHusbandChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Customer value);
        partial void OnHusbandChanged();
        /// <summary>
        /// There are no comments for Property Wife in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Customer Wife
        {
            get
            {
                return this._Wife;
            }
            set
            {
                this.OnWifeChanging(value);
                this._Wife = value;
                this.OnWifeChanged();
                this.OnPropertyChanged("Wife");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Customer _Wife;
        partial void OnWifeChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Customer value);
        partial void OnWifeChanged();
        /// <summary>
        /// There are no comments for Property Info in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.CustomerInfo Info
        {
            get
            {
                return this._Info;
            }
            set
            {
                this.OnInfoChanging(value);
                this._Info = value;
                this.OnInfoChanged();
                this.OnPropertyChanged("Info");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.CustomerInfo _Info;
        partial void OnInfoChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.CustomerInfo value);
        partial void OnInfoChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Login in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Username
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("Username")]
    [global::Microsoft.OData.Client.EntitySetAttribute("Login")]
    public partial class Login : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Login object.
        /// </summary>
        /// <param name="username">Initial value of Username.</param>
        /// <param name="customerId">Initial value of CustomerId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static Login CreateLogin(string username, double customerId)
        {
            Login login = new Login();
            login.Username = username;
            login.CustomerId = customerId;
            return login;
        }
        /// <summary>
        /// There are no comments for Property Username in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Username
        {
            get
            {
                return this._Username;
            }
            set
            {
                this.OnUsernameChanging(value);
                this._Username = value;
                this.OnUsernameChanged();
                this.OnPropertyChanged("Username");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Username;
        partial void OnUsernameChanging(string value);
        partial void OnUsernameChanged();
        /// <summary>
        /// There are no comments for Property CustomerId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public double CustomerId
        {
            get
            {
                return this._CustomerId;
            }
            set
            {
                this.OnCustomerIdChanging(value);
                this._CustomerId = value;
                this.OnCustomerIdChanged();
                this.OnPropertyChanged("CustomerId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private double _CustomerId;
        partial void OnCustomerIdChanging(double value);
        partial void OnCustomerIdChanged();
        /// <summary>
        /// There are no comments for Property Customer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Customer Customer
        {
            get
            {
                return this._Customer;
            }
            set
            {
                this.OnCustomerChanging(value);
                this._Customer = value;
                this.OnCustomerChanged();
                this.OnPropertyChanged("Customer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Customer _Customer;
        partial void OnCustomerChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Customer value);
        partial void OnCustomerChanged();
        /// <summary>
        /// There are no comments for Property LastLogin in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.LastLogin LastLogin
        {
            get
            {
                return this._LastLogin;
            }
            set
            {
                this.OnLastLoginChanging(value);
                this._LastLogin = value;
                this.OnLastLoginChanged();
                this.OnPropertyChanged("LastLogin");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.LastLogin _LastLogin;
        partial void OnLastLoginChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.LastLogin value);
        partial void OnLastLoginChanged();
        /// <summary>
        /// There are no comments for Property SentMessages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Message> SentMessages
        {
            get
            {
                return this._SentMessages;
            }
            set
            {
                this.OnSentMessagesChanging(value);
                this._SentMessages = value;
                this.OnSentMessagesChanged();
                this.OnPropertyChanged("SentMessages");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Message> _SentMessages = new global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Message>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSentMessagesChanging(global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Message> value);
        partial void OnSentMessagesChanged();
        /// <summary>
        /// There are no comments for Property ReceivedMessages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Message> ReceivedMessages
        {
            get
            {
                return this._ReceivedMessages;
            }
            set
            {
                this.OnReceivedMessagesChanging(value);
                this._ReceivedMessages = value;
                this.OnReceivedMessagesChanged();
                this.OnPropertyChanged("ReceivedMessages");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Message> _ReceivedMessages = new global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Message>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReceivedMessagesChanging(global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Message> value);
        partial void OnReceivedMessagesChanged();
        /// <summary>
        /// There are no comments for Property Orders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Order> Orders
        {
            get
            {
                return this._Orders;
            }
            set
            {
                this.OnOrdersChanging(value);
                this._Orders = value;
                this.OnOrdersChanged();
                this.OnPropertyChanged("Orders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Order> _Orders = new global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Order>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnOrdersChanging(global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Order> value);
        partial void OnOrdersChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for RSAToken in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Serial
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("Serial")]
    [global::Microsoft.OData.Client.EntitySetAttribute("RSAToken")]
    public partial class RSAToken : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RSAToken object.
        /// </summary>
        /// <param name="serial">Initial value of Serial.</param>
        /// <param name="issued">Initial value of Issued.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static RSAToken CreateRSAToken(string serial, global::System.DateTimeOffset issued)
        {
            RSAToken rSAToken = new RSAToken();
            rSAToken.Serial = serial;
            rSAToken.Issued = issued;
            return rSAToken;
        }
        /// <summary>
        /// There are no comments for Property Serial in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Serial
        {
            get
            {
                return this._Serial;
            }
            set
            {
                this.OnSerialChanging(value);
                this._Serial = value;
                this.OnSerialChanged();
                this.OnPropertyChanged("Serial");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Serial;
        partial void OnSerialChanging(string value);
        partial void OnSerialChanged();
        /// <summary>
        /// There are no comments for Property Issued in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.DateTimeOffset Issued
        {
            get
            {
                return this._Issued;
            }
            set
            {
                this.OnIssuedChanging(value);
                this._Issued = value;
                this.OnIssuedChanged();
                this.OnPropertyChanged("Issued");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.DateTimeOffset _Issued;
        partial void OnIssuedChanging(global::System.DateTimeOffset value);
        partial void OnIssuedChanged();
        /// <summary>
        /// There are no comments for Property Login in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login Login
        {
            get
            {
                return this._Login;
            }
            set
            {
                this.OnLoginChanging(value);
                this._Login = value;
                this.OnLoginChanged();
                this.OnPropertyChanged("Login");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login _Login;
        partial void OnLoginChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login value);
        partial void OnLoginChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for PageView in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PageViewId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("PageViewId")]
    [global::Microsoft.OData.Client.EntitySetAttribute("PageView")]
    public partial class PageView : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PageView object.
        /// </summary>
        /// <param name="pageViewId">Initial value of PageViewId.</param>
        /// <param name="viewed">Initial value of Viewed.</param>
        /// <param name="timeSpentOnPage">Initial value of TimeSpentOnPage.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static PageView CreatePageView(int pageViewId, string viewed, global::System.TimeSpan timeSpentOnPage)
        {
            PageView pageView = new PageView();
            pageView.PageViewId = pageViewId;
            pageView.Viewed = viewed;
            pageView.TimeSpentOnPage = timeSpentOnPage;
            return pageView;
        }
        /// <summary>
        /// There are no comments for Property PageViewId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int PageViewId
        {
            get
            {
                return this._PageViewId;
            }
            set
            {
                this.OnPageViewIdChanging(value);
                this._PageViewId = value;
                this.OnPageViewIdChanged();
                this.OnPropertyChanged("PageViewId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _PageViewId;
        partial void OnPageViewIdChanging(int value);
        partial void OnPageViewIdChanged();
        /// <summary>
        /// There are no comments for Property Username in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Username
        {
            get
            {
                return this._Username;
            }
            set
            {
                this.OnUsernameChanging(value);
                this._Username = value;
                this.OnUsernameChanged();
                this.OnPropertyChanged("Username");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Username;
        partial void OnUsernameChanging(string value);
        partial void OnUsernameChanged();
        /// <summary>
        /// There are no comments for Property Viewed in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Viewed
        {
            get
            {
                return this._Viewed;
            }
            set
            {
                this.OnViewedChanging(value);
                this._Viewed = value;
                this.OnViewedChanged();
                this.OnPropertyChanged("Viewed");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Viewed;
        partial void OnViewedChanging(string value);
        partial void OnViewedChanged();
        /// <summary>
        /// There are no comments for Property TimeSpentOnPage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.TimeSpan TimeSpentOnPage
        {
            get
            {
                return this._TimeSpentOnPage;
            }
            set
            {
                this.OnTimeSpentOnPageChanging(value);
                this._TimeSpentOnPage = value;
                this.OnTimeSpentOnPageChanged();
                this.OnPropertyChanged("TimeSpentOnPage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.TimeSpan _TimeSpentOnPage;
        partial void OnTimeSpentOnPageChanging(global::System.TimeSpan value);
        partial void OnTimeSpentOnPageChanged();
        /// <summary>
        /// There are no comments for Property PageUrl in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string PageUrl
        {
            get
            {
                return this._PageUrl;
            }
            set
            {
                this.OnPageUrlChanging(value);
                this._PageUrl = value;
                this.OnPageUrlChanged();
                this.OnPropertyChanged("PageUrl");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _PageUrl;
        partial void OnPageUrlChanging(string value);
        partial void OnPageUrlChanged();
        /// <summary>
        /// There are no comments for Property Login in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login Login
        {
            get
            {
                return this._Login;
            }
            set
            {
                this.OnLoginChanging(value);
                this._Login = value;
                this.OnLoginChanged();
                this.OnPropertyChanged("Login");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login _Login;
        partial void OnLoginChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login value);
        partial void OnLoginChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for LastLogin in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Username
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("Username")]
    [global::Microsoft.OData.Client.EntitySetAttribute("LastLogin")]
    public partial class LastLogin : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LastLogin object.
        /// </summary>
        /// <param name="username">Initial value of Username.</param>
        /// <param name="loggedIn">Initial value of LoggedIn.</param>
        /// <param name="duration">Initial value of Duration.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static LastLogin CreateLastLogin(string username, global::System.DateTimeOffset loggedIn, global::System.TimeSpan duration)
        {
            LastLogin lastLogin = new LastLogin();
            lastLogin.Username = username;
            lastLogin.LoggedIn = loggedIn;
            lastLogin.Duration = duration;
            return lastLogin;
        }
        /// <summary>
        /// There are no comments for Property Username in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Username
        {
            get
            {
                return this._Username;
            }
            set
            {
                this.OnUsernameChanging(value);
                this._Username = value;
                this.OnUsernameChanged();
                this.OnPropertyChanged("Username");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Username;
        partial void OnUsernameChanging(string value);
        partial void OnUsernameChanged();
        /// <summary>
        /// There are no comments for Property LoggedIn in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.DateTimeOffset LoggedIn
        {
            get
            {
                return this._LoggedIn;
            }
            set
            {
                this.OnLoggedInChanging(value);
                this._LoggedIn = value;
                this.OnLoggedInChanged();
                this.OnPropertyChanged("LoggedIn");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.DateTimeOffset _LoggedIn;
        partial void OnLoggedInChanging(global::System.DateTimeOffset value);
        partial void OnLoggedInChanged();
        /// <summary>
        /// There are no comments for Property LoggedOut in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Nullable<global::System.DateTimeOffset> LoggedOut
        {
            get
            {
                return this._LoggedOut;
            }
            set
            {
                this.OnLoggedOutChanging(value);
                this._LoggedOut = value;
                this.OnLoggedOutChanged();
                this.OnPropertyChanged("LoggedOut");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Nullable<global::System.DateTimeOffset> _LoggedOut;
        partial void OnLoggedOutChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnLoggedOutChanged();
        /// <summary>
        /// There are no comments for Property Duration in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.TimeSpan Duration
        {
            get
            {
                return this._Duration;
            }
            set
            {
                this.OnDurationChanging(value);
                this._Duration = value;
                this.OnDurationChanged();
                this.OnPropertyChanged("Duration");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.TimeSpan _Duration;
        partial void OnDurationChanging(global::System.TimeSpan value);
        partial void OnDurationChanged();
        /// <summary>
        /// There are no comments for Property Login in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login Login
        {
            get
            {
                return this._Login;
            }
            set
            {
                this.OnLoginChanging(value);
                this._Login = value;
                this.OnLoginChanged();
                this.OnPropertyChanged("Login");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login _Login;
        partial void OnLoginChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login value);
        partial void OnLoginChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Message in the schema.
    /// </summary>
    /// <KeyProperties>
    /// FromUsername
    /// MessageId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("FromUsername", "MessageId")]
    [global::Microsoft.OData.Client.EntitySetAttribute("Message")]
    public partial class Message : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Message object.
        /// </summary>
        /// <param name="messageId">Initial value of MessageId.</param>
        /// <param name="fromUsername">Initial value of FromUsername.</param>
        /// <param name="sent">Initial value of Sent.</param>
        /// <param name="isRead">Initial value of IsRead.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static Message CreateMessage(string messageId, string fromUsername, global::System.DateTimeOffset sent, string isRead)
        {
            Message message = new Message();
            message.MessageId = messageId;
            message.FromUsername = fromUsername;
            message.Sent = sent;
            message.IsRead = isRead;
            return message;
        }
        /// <summary>
        /// There are no comments for Property MessageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string MessageId
        {
            get
            {
                return this._MessageId;
            }
            set
            {
                this.OnMessageIdChanging(value);
                this._MessageId = value;
                this.OnMessageIdChanged();
                this.OnPropertyChanged("MessageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _MessageId;
        partial void OnMessageIdChanging(string value);
        partial void OnMessageIdChanged();
        /// <summary>
        /// There are no comments for Property FromUsername in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string FromUsername
        {
            get
            {
                return this._FromUsername;
            }
            set
            {
                this.OnFromUsernameChanging(value);
                this._FromUsername = value;
                this.OnFromUsernameChanged();
                this.OnPropertyChanged("FromUsername");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _FromUsername;
        partial void OnFromUsernameChanging(string value);
        partial void OnFromUsernameChanged();
        /// <summary>
        /// There are no comments for Property ToUsername in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string ToUsername
        {
            get
            {
                return this._ToUsername;
            }
            set
            {
                this.OnToUsernameChanging(value);
                this._ToUsername = value;
                this.OnToUsernameChanged();
                this.OnPropertyChanged("ToUsername");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _ToUsername;
        partial void OnToUsernameChanging(string value);
        partial void OnToUsernameChanged();
        /// <summary>
        /// There are no comments for Property Sent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.DateTimeOffset Sent
        {
            get
            {
                return this._Sent;
            }
            set
            {
                this.OnSentChanging(value);
                this._Sent = value;
                this.OnSentChanged();
                this.OnPropertyChanged("Sent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.DateTimeOffset _Sent;
        partial void OnSentChanging(global::System.DateTimeOffset value);
        partial void OnSentChanged();
        /// <summary>
        /// There are no comments for Property Subject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Subject
        {
            get
            {
                return this._Subject;
            }
            set
            {
                this.OnSubjectChanging(value);
                this._Subject = value;
                this.OnSubjectChanged();
                this.OnPropertyChanged("Subject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Subject;
        partial void OnSubjectChanging(string value);
        partial void OnSubjectChanged();
        /// <summary>
        /// There are no comments for Property Body in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Body
        {
            get
            {
                return this._Body;
            }
            set
            {
                this.OnBodyChanging(value);
                this._Body = value;
                this.OnBodyChanged();
                this.OnPropertyChanged("Body");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Body;
        partial void OnBodyChanging(string value);
        partial void OnBodyChanged();
        /// <summary>
        /// There are no comments for Property IsRead in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string IsRead
        {
            get
            {
                return this._IsRead;
            }
            set
            {
                this.OnIsReadChanging(value);
                this._IsRead = value;
                this.OnIsReadChanged();
                this.OnPropertyChanged("IsRead");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _IsRead;
        partial void OnIsReadChanging(string value);
        partial void OnIsReadChanged();
        /// <summary>
        /// There are no comments for Property Sender in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login Sender
        {
            get
            {
                return this._Sender;
            }
            set
            {
                this.OnSenderChanging(value);
                this._Sender = value;
                this.OnSenderChanged();
                this.OnPropertyChanged("Sender");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login _Sender;
        partial void OnSenderChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login value);
        partial void OnSenderChanged();
        /// <summary>
        /// There are no comments for Property Recipient in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login Recipient
        {
            get
            {
                return this._Recipient;
            }
            set
            {
                this.OnRecipientChanging(value);
                this._Recipient = value;
                this.OnRecipientChanged();
                this.OnPropertyChanged("Recipient");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login _Recipient;
        partial void OnRecipientChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login value);
        partial void OnRecipientChanged();
        /// <summary>
        /// There are no comments for Property Attachments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.MessageAttachment> Attachments
        {
            get
            {
                return this._Attachments;
            }
            set
            {
                this.OnAttachmentsChanging(value);
                this._Attachments = value;
                this.OnAttachmentsChanged();
                this.OnPropertyChanged("Attachments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.MessageAttachment> _Attachments = new global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.MessageAttachment>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAttachmentsChanging(global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.MessageAttachment> value);
        partial void OnAttachmentsChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for MessageAttachment in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AttachmentId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("AttachmentId")]
    [global::Microsoft.OData.Client.EntitySetAttribute("MessageAttachment")]
    public partial class MessageAttachment : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MessageAttachment object.
        /// </summary>
        /// <param name="attachmentId">Initial value of AttachmentId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static MessageAttachment CreateMessageAttachment(string attachmentId)
        {
            MessageAttachment messageAttachment = new MessageAttachment();
            messageAttachment.AttachmentId = attachmentId;
            return messageAttachment;
        }
        /// <summary>
        /// There are no comments for Property AttachmentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string AttachmentId
        {
            get
            {
                return this._AttachmentId;
            }
            set
            {
                this.OnAttachmentIdChanging(value);
                this._AttachmentId = value;
                this.OnAttachmentIdChanged();
                this.OnPropertyChanged("AttachmentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _AttachmentId;
        partial void OnAttachmentIdChanging(string value);
        partial void OnAttachmentIdChanged();
        /// <summary>
        /// There are no comments for Property Attachment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public byte[] Attachment
        {
            get
            {
                return this._Attachment;
            }
            set
            {
                this.OnAttachmentChanging(value);
                this._Attachment = value;
                this.OnAttachmentChanged();
                this.OnPropertyChanged("Attachment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private byte[] _Attachment;
        partial void OnAttachmentChanging(byte[] value);
        partial void OnAttachmentChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Order in the schema.
    /// </summary>
    /// <KeyProperties>
    /// OrderId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("OrderId")]
    [global::Microsoft.OData.Client.EntitySetAttribute("Order")]
    public partial class Order : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="orderId">Initial value of OrderId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static Order CreateOrder(int orderId)
        {
            Order order = new Order();
            order.OrderId = orderId;
            return order;
        }
        /// <summary>
        /// There are no comments for Property OrderId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int OrderId
        {
            get
            {
                return this._OrderId;
            }
            set
            {
                this.OnOrderIdChanging(value);
                this._OrderId = value;
                this.OnOrderIdChanged();
                this.OnPropertyChanged("OrderId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _OrderId;
        partial void OnOrderIdChanging(int value);
        partial void OnOrderIdChanged();
        /// <summary>
        /// There are no comments for Property CustomerId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Nullable<int> CustomerId
        {
            get
            {
                return this._CustomerId;
            }
            set
            {
                this.OnCustomerIdChanging(value);
                this._CustomerId = value;
                this.OnCustomerIdChanged();
                this.OnPropertyChanged("CustomerId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Nullable<int> _CustomerId;
        partial void OnCustomerIdChanging(global::System.Nullable<int> value);
        partial void OnCustomerIdChanged();
        /// <summary>
        /// There are no comments for Property Concurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ConcurrencyInfo Concurrency
        {
            get
            {
                return this._Concurrency;
            }
            set
            {
                this.OnConcurrencyChanging(value);
                this._Concurrency = value;
                this.OnConcurrencyChanged();
                this.OnPropertyChanged("Concurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ConcurrencyInfo _Concurrency;
        partial void OnConcurrencyChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ConcurrencyInfo value);
        partial void OnConcurrencyChanged();
        /// <summary>
        /// There are no comments for Property Login in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login Login
        {
            get
            {
                return this._Login;
            }
            set
            {
                this.OnLoginChanging(value);
                this._Login = value;
                this.OnLoginChanged();
                this.OnPropertyChanged("Login");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login _Login;
        partial void OnLoginChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Login value);
        partial void OnLoginChanged();
        /// <summary>
        /// There are no comments for Property Customer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Customer Customer
        {
            get
            {
                return this._Customer;
            }
            set
            {
                this.OnCustomerChanging(value);
                this._Customer = value;
                this.OnCustomerChanged();
                this.OnPropertyChanged("Customer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Customer _Customer;
        partial void OnCustomerChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Customer value);
        partial void OnCustomerChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for OrderLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// OrderId
    /// ProductId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("OrderId", "ProductId")]
    [global::Microsoft.OData.Client.EntitySetAttribute("OrderLine")]
    public partial class OrderLine : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new OrderLine object.
        /// </summary>
        /// <param name="orderLineStream">Initial value of OrderLineStream.</param>
        /// <param name="orderId">Initial value of OrderId.</param>
        /// <param name="productId">Initial value of ProductId.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static OrderLine CreateOrderLine(global::Microsoft.OData.Client.DataServiceStreamLink orderLineStream, int orderId, int productId, int quantity)
        {
            OrderLine orderLine = new OrderLine();
            orderLine.OrderLineStream = orderLineStream;
            orderLine.OrderId = orderId;
            orderLine.ProductId = productId;
            orderLine.Quantity = quantity;
            return orderLine;
        }
        /// <summary>
        /// There are no comments for Property OrderLineStream in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceStreamLink OrderLineStream
        {
            get
            {
                return this._OrderLineStream;
            }
            set
            {
                this.OnOrderLineStreamChanging(value);
                this._OrderLineStream = value;
                this.OnOrderLineStreamChanged();
                this.OnPropertyChanged("OrderLineStream");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceStreamLink _OrderLineStream;
        partial void OnOrderLineStreamChanging(global::Microsoft.OData.Client.DataServiceStreamLink value);
        partial void OnOrderLineStreamChanged();
        /// <summary>
        /// There are no comments for Property OrderId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int OrderId
        {
            get
            {
                return this._OrderId;
            }
            set
            {
                this.OnOrderIdChanging(value);
                this._OrderId = value;
                this.OnOrderIdChanged();
                this.OnPropertyChanged("OrderId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _OrderId;
        partial void OnOrderIdChanging(int value);
        partial void OnOrderIdChanged();
        /// <summary>
        /// There are no comments for Property ProductId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int ProductId
        {
            get
            {
                return this._ProductId;
            }
            set
            {
                this.OnProductIdChanging(value);
                this._ProductId = value;
                this.OnProductIdChanged();
                this.OnPropertyChanged("ProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _ProductId;
        partial void OnProductIdChanging(int value);
        partial void OnProductIdChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _Quantity;
        partial void OnQuantityChanging(int value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Property ConcurrencyToken in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string ConcurrencyToken
        {
            get
            {
                return this._ConcurrencyToken;
            }
            set
            {
                this.OnConcurrencyTokenChanging(value);
                this._ConcurrencyToken = value;
                this.OnConcurrencyTokenChanged();
                this.OnPropertyChanged("ConcurrencyToken");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _ConcurrencyToken;
        partial void OnConcurrencyTokenChanging(string value);
        partial void OnConcurrencyTokenChanged();
        /// <summary>
        /// There are no comments for Property Order in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Order Order
        {
            get
            {
                return this._Order;
            }
            set
            {
                this.OnOrderChanging(value);
                this._Order = value;
                this.OnOrderChanged();
                this.OnPropertyChanged("Order");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Order _Order;
        partial void OnOrderChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Order value);
        partial void OnOrderChanged();
        /// <summary>
        /// There are no comments for Property Product in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this.OnProductChanging(value);
                this._Product = value;
                this.OnProductChanged();
                this.OnPropertyChanged("Product");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Product _Product;
        partial void OnProductChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Product value);
        partial void OnProductChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Product in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("ProductId")]
    [global::Microsoft.OData.Client.EntitySetAttribute("Product")]
    public partial class Product : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="picture">Initial value of Picture.</param>
        /// <param name="productId">Initial value of ProductId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static Product CreateProduct(global::Microsoft.OData.Client.DataServiceStreamLink picture, int productId)
        {
            Product product = new Product();
            product.Picture = picture;
            product.ProductId = productId;
            return product;
        }
        /// <summary>
        /// There are no comments for Property Picture in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceStreamLink Picture
        {
            get
            {
                return this._Picture;
            }
            set
            {
                this.OnPictureChanging(value);
                this._Picture = value;
                this.OnPictureChanged();
                this.OnPropertyChanged("Picture");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceStreamLink _Picture;
        partial void OnPictureChanging(global::Microsoft.OData.Client.DataServiceStreamLink value);
        partial void OnPictureChanged();
        /// <summary>
        /// There are no comments for Property ProductId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int ProductId
        {
            get
            {
                return this._ProductId;
            }
            set
            {
                this.OnProductIdChanging(value);
                this._ProductId = value;
                this.OnProductIdChanged();
                this.OnPropertyChanged("ProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _ProductId;
        partial void OnProductIdChanging(int value);
        partial void OnProductIdChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Dimensions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Dimensions Dimensions
        {
            get
            {
                return this._Dimensions;
            }
            set
            {
                this.OnDimensionsChanging(value);
                this._Dimensions = value;
                this.OnDimensionsChanged();
                this.OnPropertyChanged("Dimensions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Dimensions _Dimensions;
        partial void OnDimensionsChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Dimensions value);
        partial void OnDimensionsChanged();
        /// <summary>
        /// There are no comments for Property BaseConcurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string BaseConcurrency
        {
            get
            {
                return this._BaseConcurrency;
            }
            set
            {
                this.OnBaseConcurrencyChanging(value);
                this._BaseConcurrency = value;
                this.OnBaseConcurrencyChanged();
                this.OnPropertyChanged("BaseConcurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _BaseConcurrency;
        partial void OnBaseConcurrencyChanging(string value);
        partial void OnBaseConcurrencyChanged();
        /// <summary>
        /// There are no comments for Property ComplexConcurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ConcurrencyInfo ComplexConcurrency
        {
            get
            {
                return this._ComplexConcurrency;
            }
            set
            {
                this.OnComplexConcurrencyChanging(value);
                this._ComplexConcurrency = value;
                this.OnComplexConcurrencyChanged();
                this.OnPropertyChanged("ComplexConcurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ConcurrencyInfo _ComplexConcurrency;
        partial void OnComplexConcurrencyChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ConcurrencyInfo value);
        partial void OnComplexConcurrencyChanged();
        /// <summary>
        /// There are no comments for Property NestedComplexConcurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.AuditInfo NestedComplexConcurrency
        {
            get
            {
                return this._NestedComplexConcurrency;
            }
            set
            {
                this.OnNestedComplexConcurrencyChanging(value);
                this._NestedComplexConcurrency = value;
                this.OnNestedComplexConcurrencyChanged();
                this.OnPropertyChanged("NestedComplexConcurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.AuditInfo _NestedComplexConcurrency;
        partial void OnNestedComplexConcurrencyChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.AuditInfo value);
        partial void OnNestedComplexConcurrencyChanged();
        /// <summary>
        /// There are no comments for Property RelatedProducts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Product> RelatedProducts
        {
            get
            {
                return this._RelatedProducts;
            }
            set
            {
                this.OnRelatedProductsChanging(value);
                this._RelatedProducts = value;
                this.OnRelatedProductsChanged();
                this.OnPropertyChanged("RelatedProducts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Product> _RelatedProducts = new global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Product>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnRelatedProductsChanging(global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Product> value);
        partial void OnRelatedProductsChanged();
        /// <summary>
        /// There are no comments for Property Detail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ProductDetail Detail
        {
            get
            {
                return this._Detail;
            }
            set
            {
                this.OnDetailChanging(value);
                this._Detail = value;
                this.OnDetailChanged();
                this.OnPropertyChanged("Detail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ProductDetail _Detail;
        partial void OnDetailChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ProductDetail value);
        partial void OnDetailChanged();
        /// <summary>
        /// There are no comments for Property Reviews in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ProductReview> Reviews
        {
            get
            {
                return this._Reviews;
            }
            set
            {
                this.OnReviewsChanging(value);
                this._Reviews = value;
                this.OnReviewsChanged();
                this.OnPropertyChanged("Reviews");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ProductReview> _Reviews = new global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ProductReview>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnReviewsChanging(global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ProductReview> value);
        partial void OnReviewsChanged();
        /// <summary>
        /// There are no comments for Property Photos in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ProductPhoto> Photos
        {
            get
            {
                return this._Photos;
            }
            set
            {
                this.OnPhotosChanging(value);
                this._Photos = value;
                this.OnPhotosChanged();
                this.OnPropertyChanged("Photos");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ProductPhoto> _Photos = new global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ProductPhoto>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPhotosChanging(global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ProductPhoto> value);
        partial void OnPhotosChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ProductDetail in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("ProductId")]
    [global::Microsoft.OData.Client.EntitySetAttribute("ProductDetail")]
    public partial class ProductDetail : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductDetail object.
        /// </summary>
        /// <param name="productId">Initial value of ProductId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static ProductDetail CreateProductDetail(int productId)
        {
            ProductDetail productDetail = new ProductDetail();
            productDetail.ProductId = productId;
            return productDetail;
        }
        /// <summary>
        /// There are no comments for Property ProductId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int ProductId
        {
            get
            {
                return this._ProductId;
            }
            set
            {
                this.OnProductIdChanging(value);
                this._ProductId = value;
                this.OnProductIdChanged();
                this.OnPropertyChanged("ProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _ProductId;
        partial void OnProductIdChanging(int value);
        partial void OnProductIdChanged();
        /// <summary>
        /// There are no comments for Property Details in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Details
        {
            get
            {
                return this._Details;
            }
            set
            {
                this.OnDetailsChanging(value);
                this._Details = value;
                this.OnDetailsChanged();
                this.OnPropertyChanged("Details");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Details;
        partial void OnDetailsChanging(string value);
        partial void OnDetailsChanged();
        /// <summary>
        /// There are no comments for Property Product in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this.OnProductChanging(value);
                this._Product = value;
                this.OnProductChanged();
                this.OnPropertyChanged("Product");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Product _Product;
        partial void OnProductChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Product value);
        partial void OnProductChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ProductReview in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductId
    /// ReviewId
    /// RevisionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("ProductId", "ReviewId", "RevisionId")]
    [global::Microsoft.OData.Client.EntitySetAttribute("ProductReview")]
    public partial class ProductReview : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductReview object.
        /// </summary>
        /// <param name="productId">Initial value of ProductId.</param>
        /// <param name="reviewId">Initial value of ReviewId.</param>
        /// <param name="revisionId">Initial value of RevisionId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static ProductReview CreateProductReview(int productId, int reviewId, string revisionId)
        {
            ProductReview productReview = new ProductReview();
            productReview.ProductId = productId;
            productReview.ReviewId = reviewId;
            productReview.RevisionId = revisionId;
            return productReview;
        }
        /// <summary>
        /// There are no comments for Property ProductId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int ProductId
        {
            get
            {
                return this._ProductId;
            }
            set
            {
                this.OnProductIdChanging(value);
                this._ProductId = value;
                this.OnProductIdChanged();
                this.OnPropertyChanged("ProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _ProductId;
        partial void OnProductIdChanging(int value);
        partial void OnProductIdChanged();
        /// <summary>
        /// There are no comments for Property ReviewId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int ReviewId
        {
            get
            {
                return this._ReviewId;
            }
            set
            {
                this.OnReviewIdChanging(value);
                this._ReviewId = value;
                this.OnReviewIdChanged();
                this.OnPropertyChanged("ReviewId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _ReviewId;
        partial void OnReviewIdChanging(int value);
        partial void OnReviewIdChanged();
        /// <summary>
        /// There are no comments for Property Review in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Review
        {
            get
            {
                return this._Review;
            }
            set
            {
                this.OnReviewChanging(value);
                this._Review = value;
                this.OnReviewChanged();
                this.OnPropertyChanged("Review");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Review;
        partial void OnReviewChanging(string value);
        partial void OnReviewChanged();
        /// <summary>
        /// There are no comments for Property RevisionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string RevisionId
        {
            get
            {
                return this._RevisionId;
            }
            set
            {
                this.OnRevisionIdChanging(value);
                this._RevisionId = value;
                this.OnRevisionIdChanged();
                this.OnPropertyChanged("RevisionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _RevisionId;
        partial void OnRevisionIdChanging(string value);
        partial void OnRevisionIdChanged();
        /// <summary>
        /// There are no comments for Property Product in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Product Product
        {
            get
            {
                return this._Product;
            }
            set
            {
                this.OnProductChanging(value);
                this._Product = value;
                this.OnProductChanged();
                this.OnPropertyChanged("Product");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Product _Product;
        partial void OnProductChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Product value);
        partial void OnProductChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ProductPhoto in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PhotoId
    /// ProductId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("PhotoId", "ProductId")]
    [global::Microsoft.OData.Client.EntitySetAttribute("ProductPhoto")]
    public partial class ProductPhoto : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductPhoto object.
        /// </summary>
        /// <param name="productId">Initial value of ProductId.</param>
        /// <param name="photoId">Initial value of PhotoId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static ProductPhoto CreateProductPhoto(int productId, int photoId)
        {
            ProductPhoto productPhoto = new ProductPhoto();
            productPhoto.ProductId = productId;
            productPhoto.PhotoId = photoId;
            return productPhoto;
        }
        /// <summary>
        /// There are no comments for Property ProductId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int ProductId
        {
            get
            {
                return this._ProductId;
            }
            set
            {
                this.OnProductIdChanging(value);
                this._ProductId = value;
                this.OnProductIdChanged();
                this.OnPropertyChanged("ProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _ProductId;
        partial void OnProductIdChanging(int value);
        partial void OnProductIdChanged();
        /// <summary>
        /// There are no comments for Property PhotoId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int PhotoId
        {
            get
            {
                return this._PhotoId;
            }
            set
            {
                this.OnPhotoIdChanging(value);
                this._PhotoId = value;
                this.OnPhotoIdChanged();
                this.OnPropertyChanged("PhotoId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _PhotoId;
        partial void OnPhotoIdChanging(int value);
        partial void OnPhotoIdChanged();
        /// <summary>
        /// There are no comments for Property Photo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public byte[] Photo
        {
            get
            {
                return this._Photo;
            }
            set
            {
                this.OnPhotoChanging(value);
                this._Photo = value;
                this.OnPhotoChanged();
                this.OnPropertyChanged("Photo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private byte[] _Photo;
        partial void OnPhotoChanging(byte[] value);
        partial void OnPhotoChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for CustomerInfo in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CustomerInfoId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("CustomerInfoId")]
    [global::Microsoft.OData.Client.EntitySetAttribute("CustomerInfo")]
    [global::Microsoft.OData.Client.HasStreamAttribute()]
    public partial class CustomerInfo : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CustomerInfo object.
        /// </summary>
        /// <param name="customerInfoId">Initial value of CustomerInfoId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static CustomerInfo CreateCustomerInfo(int customerInfoId)
        {
            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.CustomerInfoId = customerInfoId;
            return customerInfo;
        }
        /// <summary>
        /// There are no comments for Property CustomerInfoId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int CustomerInfoId
        {
            get
            {
                return this._CustomerInfoId;
            }
            set
            {
                this.OnCustomerInfoIdChanging(value);
                this._CustomerInfoId = value;
                this.OnCustomerInfoIdChanged();
                this.OnPropertyChanged("CustomerInfoId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _CustomerInfoId;
        partial void OnCustomerInfoIdChanging(int value);
        partial void OnCustomerInfoIdChanged();
        /// <summary>
        /// There are no comments for Property Information in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Information
        {
            get
            {
                return this._Information;
            }
            set
            {
                this.OnInformationChanging(value);
                this._Information = value;
                this.OnInformationChanged();
                this.OnPropertyChanged("Information");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Information;
        partial void OnInformationChanging(string value);
        partial void OnInformationChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Computer in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ComputerId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("ComputerId")]
    [global::Microsoft.OData.Client.EntitySetAttribute("Computer")]
    public partial class Computer : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Computer object.
        /// </summary>
        /// <param name="computerId">Initial value of ComputerId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static Computer CreateComputer(int computerId)
        {
            Computer computer = new Computer();
            computer.ComputerId = computerId;
            return computer;
        }
        /// <summary>
        /// There are no comments for Property ComputerId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int ComputerId
        {
            get
            {
                return this._ComputerId;
            }
            set
            {
                this.OnComputerIdChanging(value);
                this._ComputerId = value;
                this.OnComputerIdChanged();
                this.OnPropertyChanged("ComputerId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _ComputerId;
        partial void OnComputerIdChanging(int value);
        partial void OnComputerIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property ComputerDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ComputerDetail ComputerDetail
        {
            get
            {
                return this._ComputerDetail;
            }
            set
            {
                this.OnComputerDetailChanging(value);
                this._ComputerDetail = value;
                this.OnComputerDetailChanged();
                this.OnPropertyChanged("ComputerDetail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ComputerDetail _ComputerDetail;
        partial void OnComputerDetailChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ComputerDetail value);
        partial void OnComputerDetailChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ComputerDetail in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ComputerDetailId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("ComputerDetailId")]
    [global::Microsoft.OData.Client.EntitySetAttribute("ComputerDetail")]
    public partial class ComputerDetail : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ComputerDetail object.
        /// </summary>
        /// <param name="computerDetailId">Initial value of ComputerDetailId.</param>
        /// <param name="purchaseDate">Initial value of PurchaseDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static ComputerDetail CreateComputerDetail(int computerDetailId, global::System.DateTimeOffset purchaseDate)
        {
            ComputerDetail computerDetail = new ComputerDetail();
            computerDetail.ComputerDetailId = computerDetailId;
            computerDetail.PurchaseDate = purchaseDate;
            return computerDetail;
        }
        /// <summary>
        /// There are no comments for Property ComputerDetailId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int ComputerDetailId
        {
            get
            {
                return this._ComputerDetailId;
            }
            set
            {
                this.OnComputerDetailIdChanging(value);
                this._ComputerDetailId = value;
                this.OnComputerDetailIdChanged();
                this.OnPropertyChanged("ComputerDetailId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _ComputerDetailId;
        partial void OnComputerDetailIdChanging(int value);
        partial void OnComputerDetailIdChanged();
        /// <summary>
        /// There are no comments for Property Manufacturer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Manufacturer
        {
            get
            {
                return this._Manufacturer;
            }
            set
            {
                this.OnManufacturerChanging(value);
                this._Manufacturer = value;
                this.OnManufacturerChanged();
                this.OnPropertyChanged("Manufacturer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Manufacturer;
        partial void OnManufacturerChanging(string value);
        partial void OnManufacturerChanged();
        /// <summary>
        /// There are no comments for Property Model in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Model
        {
            get
            {
                return this._Model;
            }
            set
            {
                this.OnModelChanging(value);
                this._Model = value;
                this.OnModelChanged();
                this.OnPropertyChanged("Model");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Model;
        partial void OnModelChanging(string value);
        partial void OnModelChanged();
        /// <summary>
        /// There are no comments for Property Serial in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Serial
        {
            get
            {
                return this._Serial;
            }
            set
            {
                this.OnSerialChanging(value);
                this._Serial = value;
                this.OnSerialChanged();
                this.OnPropertyChanged("Serial");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Serial;
        partial void OnSerialChanging(string value);
        partial void OnSerialChanged();
        /// <summary>
        /// There are no comments for Property SpecificationsBag in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<string> SpecificationsBag
        {
            get
            {
                return this._SpecificationsBag;
            }
            set
            {
                this.OnSpecificationsBagChanging(value);
                this._SpecificationsBag = value;
                this.OnSpecificationsBagChanged();
                this.OnPropertyChanged("SpecificationsBag");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _SpecificationsBag = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnSpecificationsBagChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnSpecificationsBagChanged();
        /// <summary>
        /// There are no comments for Property PurchaseDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.DateTimeOffset PurchaseDate
        {
            get
            {
                return this._PurchaseDate;
            }
            set
            {
                this.OnPurchaseDateChanging(value);
                this._PurchaseDate = value;
                this.OnPurchaseDateChanged();
                this.OnPropertyChanged("PurchaseDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.DateTimeOffset _PurchaseDate;
        partial void OnPurchaseDateChanging(global::System.DateTimeOffset value);
        partial void OnPurchaseDateChanged();
        /// <summary>
        /// There are no comments for Property Dimensions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Dimensions Dimensions
        {
            get
            {
                return this._Dimensions;
            }
            set
            {
                this.OnDimensionsChanging(value);
                this._Dimensions = value;
                this.OnDimensionsChanged();
                this.OnPropertyChanged("Dimensions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Dimensions _Dimensions;
        partial void OnDimensionsChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Dimensions value);
        partial void OnDimensionsChanged();
        /// <summary>
        /// There are no comments for Property Computer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Computer Computer
        {
            get
            {
                return this._Computer;
            }
            set
            {
                this.OnComputerChanging(value);
                this._Computer = value;
                this.OnComputerChanged();
                this.OnPropertyChanged("Computer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Computer _Computer;
        partial void OnComputerChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Computer value);
        partial void OnComputerChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Driver in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("Name")]
    [global::Microsoft.OData.Client.EntitySetAttribute("Driver")]
    public partial class Driver : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Driver object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="birthDate">Initial value of BirthDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static Driver CreateDriver(string name, global::System.DateTimeOffset birthDate)
        {
            Driver driver = new Driver();
            driver.Name = name;
            driver.BirthDate = birthDate;
            return driver;
        }
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property BirthDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.DateTimeOffset BirthDate
        {
            get
            {
                return this._BirthDate;
            }
            set
            {
                this.OnBirthDateChanging(value);
                this._BirthDate = value;
                this.OnBirthDateChanged();
                this.OnPropertyChanged("BirthDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.DateTimeOffset _BirthDate;
        partial void OnBirthDateChanging(global::System.DateTimeOffset value);
        partial void OnBirthDateChanged();
        /// <summary>
        /// There are no comments for Property License in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.License License
        {
            get
            {
                return this._License;
            }
            set
            {
                this.OnLicenseChanging(value);
                this._License = value;
                this.OnLicenseChanged();
                this.OnPropertyChanged("License");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.License _License;
        partial void OnLicenseChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.License value);
        partial void OnLicenseChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for License in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("Name")]
    [global::Microsoft.OData.Client.EntitySetAttribute("License")]
    public partial class License : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new License object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="expirationDate">Initial value of ExpirationDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static License CreateLicense(string name, global::System.DateTimeOffset expirationDate)
        {
            License license = new License();
            license.Name = name;
            license.ExpirationDate = expirationDate;
            return license;
        }
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property LicenseNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string LicenseNumber
        {
            get
            {
                return this._LicenseNumber;
            }
            set
            {
                this.OnLicenseNumberChanging(value);
                this._LicenseNumber = value;
                this.OnLicenseNumberChanged();
                this.OnPropertyChanged("LicenseNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _LicenseNumber;
        partial void OnLicenseNumberChanging(string value);
        partial void OnLicenseNumberChanged();
        /// <summary>
        /// There are no comments for Property LicenseClass in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string LicenseClass
        {
            get
            {
                return this._LicenseClass;
            }
            set
            {
                this.OnLicenseClassChanging(value);
                this._LicenseClass = value;
                this.OnLicenseClassChanged();
                this.OnPropertyChanged("LicenseClass");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _LicenseClass;
        partial void OnLicenseClassChanging(string value);
        partial void OnLicenseClassChanged();
        /// <summary>
        /// There are no comments for Property Restrictions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Restrictions
        {
            get
            {
                return this._Restrictions;
            }
            set
            {
                this.OnRestrictionsChanging(value);
                this._Restrictions = value;
                this.OnRestrictionsChanged();
                this.OnPropertyChanged("Restrictions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Restrictions;
        partial void OnRestrictionsChanging(string value);
        partial void OnRestrictionsChanged();
        /// <summary>
        /// There are no comments for Property ExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.DateTimeOffset ExpirationDate
        {
            get
            {
                return this._ExpirationDate;
            }
            set
            {
                this.OnExpirationDateChanging(value);
                this._ExpirationDate = value;
                this.OnExpirationDateChanged();
                this.OnPropertyChanged("ExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.DateTimeOffset _ExpirationDate;
        partial void OnExpirationDateChanging(global::System.DateTimeOffset value);
        partial void OnExpirationDateChanged();
        /// <summary>
        /// There are no comments for Property Driver in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Driver Driver
        {
            get
            {
                return this._Driver;
            }
            set
            {
                this.OnDriverChanging(value);
                this._Driver = value;
                this.OnDriverChanged();
                this.OnPropertyChanged("Driver");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Driver _Driver;
        partial void OnDriverChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Driver value);
        partial void OnDriverChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for MappedEntityType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("Id")]
    [global::Microsoft.OData.Client.EntitySetAttribute("MappedEntityType")]
    public partial class MappedEntityType : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new MappedEntityType object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="length">Initial value of Length.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static MappedEntityType CreateMappedEntityType(int ID, int length)
        {
            MappedEntityType mappedEntityType = new MappedEntityType();
            mappedEntityType.Id = ID;
            mappedEntityType.Length = length;
            return mappedEntityType;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Href in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Href
        {
            get
            {
                return this._Href;
            }
            set
            {
                this.OnHrefChanging(value);
                this._Href = value;
                this.OnHrefChanged();
                this.OnPropertyChanged("Href");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Href;
        partial void OnHrefChanging(string value);
        partial void OnHrefChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property HrefLang in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string HrefLang
        {
            get
            {
                return this._HrefLang;
            }
            set
            {
                this.OnHrefLangChanging(value);
                this._HrefLang = value;
                this.OnHrefLangChanged();
                this.OnPropertyChanged("HrefLang");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _HrefLang;
        partial void OnHrefLangChanging(string value);
        partial void OnHrefLangChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Type;
        partial void OnTypeChanging(string value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property Length in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int Length
        {
            get
            {
                return this._Length;
            }
            set
            {
                this.OnLengthChanging(value);
                this._Length = value;
                this.OnLengthChanged();
                this.OnPropertyChanged("Length");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _Length;
        partial void OnLengthChanging(int value);
        partial void OnLengthChanged();
        /// <summary>
        /// There are no comments for Property BagOfPrimitiveToLinks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<string> BagOfPrimitiveToLinks
        {
            get
            {
                return this._BagOfPrimitiveToLinks;
            }
            set
            {
                this.OnBagOfPrimitiveToLinksChanging(value);
                this._BagOfPrimitiveToLinks = value;
                this.OnBagOfPrimitiveToLinksChanged();
                this.OnPropertyChanged("BagOfPrimitiveToLinks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _BagOfPrimitiveToLinks = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnBagOfPrimitiveToLinksChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnBagOfPrimitiveToLinksChanged();
        /// <summary>
        /// There are no comments for Property Logo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public byte[] Logo
        {
            get
            {
                return this._Logo;
            }
            set
            {
                this.OnLogoChanging(value);
                this._Logo = value;
                this.OnLogoChanged();
                this.OnPropertyChanged("Logo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private byte[] _Logo;
        partial void OnLogoChanging(byte[] value);
        partial void OnLogoChanged();
        /// <summary>
        /// There are no comments for Property BagOfDecimals in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<decimal> BagOfDecimals
        {
            get
            {
                return this._BagOfDecimals;
            }
            set
            {
                this.OnBagOfDecimalsChanging(value);
                this._BagOfDecimals = value;
                this.OnBagOfDecimalsChanged();
                this.OnPropertyChanged("BagOfDecimals");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<decimal> _BagOfDecimals = new global::System.Collections.ObjectModel.ObservableCollection<decimal>();
        partial void OnBagOfDecimalsChanging(global::System.Collections.ObjectModel.ObservableCollection<decimal> value);
        partial void OnBagOfDecimalsChanged();
        /// <summary>
        /// There are no comments for Property BagOfDoubles in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<double> BagOfDoubles
        {
            get
            {
                return this._BagOfDoubles;
            }
            set
            {
                this.OnBagOfDoublesChanging(value);
                this._BagOfDoubles = value;
                this.OnBagOfDoublesChanged();
                this.OnPropertyChanged("BagOfDoubles");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<double> _BagOfDoubles = new global::System.Collections.ObjectModel.ObservableCollection<double>();
        partial void OnBagOfDoublesChanging(global::System.Collections.ObjectModel.ObservableCollection<double> value);
        partial void OnBagOfDoublesChanged();
        /// <summary>
        /// There are no comments for Property BagOfSingles in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<float> BagOfSingles
        {
            get
            {
                return this._BagOfSingles;
            }
            set
            {
                this.OnBagOfSinglesChanging(value);
                this._BagOfSingles = value;
                this.OnBagOfSinglesChanged();
                this.OnPropertyChanged("BagOfSingles");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<float> _BagOfSingles = new global::System.Collections.ObjectModel.ObservableCollection<float>();
        partial void OnBagOfSinglesChanging(global::System.Collections.ObjectModel.ObservableCollection<float> value);
        partial void OnBagOfSinglesChanged();
        /// <summary>
        /// There are no comments for Property BagOfBytes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<byte> BagOfBytes
        {
            get
            {
                return this._BagOfBytes;
            }
            set
            {
                this.OnBagOfBytesChanging(value);
                this._BagOfBytes = value;
                this.OnBagOfBytesChanged();
                this.OnPropertyChanged("BagOfBytes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<byte> _BagOfBytes = new global::System.Collections.ObjectModel.ObservableCollection<byte>();
        partial void OnBagOfBytesChanging(global::System.Collections.ObjectModel.ObservableCollection<byte> value);
        partial void OnBagOfBytesChanged();
        /// <summary>
        /// There are no comments for Property BagOfInt16s in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<short> BagOfInt16s
        {
            get
            {
                return this._BagOfInt16s;
            }
            set
            {
                this.OnBagOfInt16sChanging(value);
                this._BagOfInt16s = value;
                this.OnBagOfInt16sChanged();
                this.OnPropertyChanged("BagOfInt16s");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<short> _BagOfInt16s = new global::System.Collections.ObjectModel.ObservableCollection<short>();
        partial void OnBagOfInt16sChanging(global::System.Collections.ObjectModel.ObservableCollection<short> value);
        partial void OnBagOfInt16sChanged();
        /// <summary>
        /// There are no comments for Property BagOfInt32s in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<int> BagOfInt32s
        {
            get
            {
                return this._BagOfInt32s;
            }
            set
            {
                this.OnBagOfInt32sChanging(value);
                this._BagOfInt32s = value;
                this.OnBagOfInt32sChanged();
                this.OnPropertyChanged("BagOfInt32s");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<int> _BagOfInt32s = new global::System.Collections.ObjectModel.ObservableCollection<int>();
        partial void OnBagOfInt32sChanging(global::System.Collections.ObjectModel.ObservableCollection<int> value);
        partial void OnBagOfInt32sChanged();
        /// <summary>
        /// There are no comments for Property BagOfInt64s in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<long> BagOfInt64s
        {
            get
            {
                return this._BagOfInt64s;
            }
            set
            {
                this.OnBagOfInt64sChanging(value);
                this._BagOfInt64s = value;
                this.OnBagOfInt64sChanged();
                this.OnPropertyChanged("BagOfInt64s");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<long> _BagOfInt64s = new global::System.Collections.ObjectModel.ObservableCollection<long>();
        partial void OnBagOfInt64sChanging(global::System.Collections.ObjectModel.ObservableCollection<long> value);
        partial void OnBagOfInt64sChanged();
        /// <summary>
        /// There are no comments for Property BagOfGuids in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<global::System.Guid> BagOfGuids
        {
            get
            {
                return this._BagOfGuids;
            }
            set
            {
                this.OnBagOfGuidsChanging(value);
                this._BagOfGuids = value;
                this.OnBagOfGuidsChanged();
                this.OnPropertyChanged("BagOfGuids");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::System.Guid> _BagOfGuids = new global::System.Collections.ObjectModel.ObservableCollection<global::System.Guid>();
        partial void OnBagOfGuidsChanging(global::System.Collections.ObjectModel.ObservableCollection<global::System.Guid> value);
        partial void OnBagOfGuidsChanged();
        /// <summary>
        /// There are no comments for Property BagOfDateTimeOffset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTimeOffset> BagOfDateTimeOffset
        {
            get
            {
                return this._BagOfDateTimeOffset;
            }
            set
            {
                this.OnBagOfDateTimeOffsetChanging(value);
                this._BagOfDateTimeOffset = value;
                this.OnBagOfDateTimeOffsetChanged();
                this.OnPropertyChanged("BagOfDateTimeOffset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTimeOffset> _BagOfDateTimeOffset = new global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTimeOffset>();
        partial void OnBagOfDateTimeOffsetChanging(global::System.Collections.ObjectModel.ObservableCollection<global::System.DateTimeOffset> value);
        partial void OnBagOfDateTimeOffsetChanged();
        /// <summary>
        /// There are no comments for Property BagOfComplexToCategories in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ComplexToCategory> BagOfComplexToCategories
        {
            get
            {
                return this._BagOfComplexToCategories;
            }
            set
            {
                this.OnBagOfComplexToCategoriesChanging(value);
                this._BagOfComplexToCategories = value;
                this.OnBagOfComplexToCategoriesChanged();
                this.OnPropertyChanged("BagOfComplexToCategories");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ComplexToCategory> _BagOfComplexToCategories = new global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ComplexToCategory>();
        partial void OnBagOfComplexToCategoriesChanging(global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ComplexToCategory> value);
        partial void OnBagOfComplexToCategoriesChanged();
        /// <summary>
        /// There are no comments for Property ComplexPhone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone ComplexPhone
        {
            get
            {
                return this._ComplexPhone;
            }
            set
            {
                this.OnComplexPhoneChanging(value);
                this._ComplexPhone = value;
                this.OnComplexPhoneChanged();
                this.OnPropertyChanged("ComplexPhone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone _ComplexPhone;
        partial void OnComplexPhoneChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone value);
        partial void OnComplexPhoneChanged();
        /// <summary>
        /// There are no comments for Property ComplexContactDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ContactDetails ComplexContactDetails
        {
            get
            {
                return this._ComplexContactDetails;
            }
            set
            {
                this.OnComplexContactDetailsChanging(value);
                this._ComplexContactDetails = value;
                this.OnComplexContactDetailsChanged();
                this.OnPropertyChanged("ComplexContactDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ContactDetails _ComplexContactDetails;
        partial void OnComplexContactDetailsChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ContactDetails value);
        partial void OnComplexContactDetailsChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Car in the schema.
    /// </summary>
    /// <KeyProperties>
    /// VIN
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("VIN")]
    [global::Microsoft.OData.Client.EntitySetAttribute("Car")]
    [global::Microsoft.OData.Client.HasStreamAttribute()]
    public partial class Car : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Car object.
        /// </summary>
        /// <param name="photo">Initial value of Photo.</param>
        /// <param name="video">Initial value of Video.</param>
        /// <param name="vIN">Initial value of VIN.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static Car CreateCar(global::Microsoft.OData.Client.DataServiceStreamLink photo, global::Microsoft.OData.Client.DataServiceStreamLink video, int vIN)
        {
            Car car = new Car();
            car.Photo = photo;
            car.Video = video;
            car.VIN = vIN;
            return car;
        }
        /// <summary>
        /// There are no comments for Property Photo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceStreamLink Photo
        {
            get
            {
                return this._Photo;
            }
            set
            {
                this.OnPhotoChanging(value);
                this._Photo = value;
                this.OnPhotoChanged();
                this.OnPropertyChanged("Photo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceStreamLink _Photo;
        partial void OnPhotoChanging(global::Microsoft.OData.Client.DataServiceStreamLink value);
        partial void OnPhotoChanged();
        /// <summary>
        /// There are no comments for Property Video in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceStreamLink Video
        {
            get
            {
                return this._Video;
            }
            set
            {
                this.OnVideoChanging(value);
                this._Video = value;
                this.OnVideoChanged();
                this.OnPropertyChanged("Video");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceStreamLink _Video;
        partial void OnVideoChanging(global::Microsoft.OData.Client.DataServiceStreamLink value);
        partial void OnVideoChanged();
        /// <summary>
        /// There are no comments for Property VIN in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int VIN
        {
            get
            {
                return this._VIN;
            }
            set
            {
                this.OnVINChanging(value);
                this._VIN = value;
                this.OnVINChanged();
                this.OnPropertyChanged("VIN");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _VIN;
        partial void OnVINChanging(int value);
        partial void OnVINChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Person in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("PersonId")]
    [global::Microsoft.OData.Client.EntitySetAttribute("Person")]
    public partial class Person : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Person object.
        /// </summary>
        /// <param name="personId">Initial value of PersonId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static Person CreatePerson(int personId)
        {
            Person person = new Person();
            person.PersonId = personId;
            return person;
        }
        /// <summary>
        /// There are no comments for Property PersonId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int PersonId
        {
            get
            {
                return this._PersonId;
            }
            set
            {
                this.OnPersonIdChanging(value);
                this._PersonId = value;
                this.OnPersonIdChanged();
                this.OnPropertyChanged("PersonId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _PersonId;
        partial void OnPersonIdChanging(int value);
        partial void OnPersonIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property PersonMetadata in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.PersonMetadata> PersonMetadata
        {
            get
            {
                return this._PersonMetadata;
            }
            set
            {
                this.OnPersonMetadataChanging(value);
                this._PersonMetadata = value;
                this.OnPersonMetadataChanged();
                this.OnPropertyChanged("PersonMetadata");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.PersonMetadata> _PersonMetadata = new global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.PersonMetadata>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPersonMetadataChanging(global::Microsoft.OData.Client.DataServiceCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.PersonMetadata> value);
        partial void OnPersonMetadataChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for PersonMetadata in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonMetadataId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("PersonMetadataId")]
    [global::Microsoft.OData.Client.EntitySetAttribute("PersonMetadata")]
    public partial class PersonMetadata : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PersonMetadata object.
        /// </summary>
        /// <param name="personMetadataId">Initial value of PersonMetadataId.</param>
        /// <param name="personId">Initial value of PersonId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static PersonMetadata CreatePersonMetadata(int personMetadataId, int personId)
        {
            PersonMetadata personMetadata = new PersonMetadata();
            personMetadata.PersonMetadataId = personMetadataId;
            personMetadata.PersonId = personId;
            return personMetadata;
        }
        /// <summary>
        /// There are no comments for Property PersonMetadataId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int PersonMetadataId
        {
            get
            {
                return this._PersonMetadataId;
            }
            set
            {
                this.OnPersonMetadataIdChanging(value);
                this._PersonMetadataId = value;
                this.OnPersonMetadataIdChanged();
                this.OnPropertyChanged("PersonMetadataId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _PersonMetadataId;
        partial void OnPersonMetadataIdChanging(int value);
        partial void OnPersonMetadataIdChanged();
        /// <summary>
        /// There are no comments for Property PersonId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int PersonId
        {
            get
            {
                return this._PersonId;
            }
            set
            {
                this.OnPersonIdChanging(value);
                this._PersonId = value;
                this.OnPersonIdChanged();
                this.OnPropertyChanged("PersonId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _PersonId;
        partial void OnPersonIdChanging(int value);
        partial void OnPersonIdChanged();
        /// <summary>
        /// There are no comments for Property PropertyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string PropertyName
        {
            get
            {
                return this._PropertyName;
            }
            set
            {
                this.OnPropertyNameChanging(value);
                this._PropertyName = value;
                this.OnPropertyNameChanged();
                this.OnPropertyChanged("PropertyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _PropertyName;
        partial void OnPropertyNameChanging(string value);
        partial void OnPropertyNameChanged();
        /// <summary>
        /// There are no comments for Property PropertyValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string PropertyValue
        {
            get
            {
                return this._PropertyValue;
            }
            set
            {
                this.OnPropertyValueChanging(value);
                this._PropertyValue = value;
                this.OnPropertyValueChanged();
                this.OnPropertyChanged("PropertyValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _PropertyValue;
        partial void OnPropertyValueChanging(string value);
        partial void OnPropertyValueChanged();
        /// <summary>
        /// There are no comments for Property Person in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Person Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                this.OnPersonChanging(value);
                this._Person = value;
                this.OnPersonChanged();
                this.OnPropertyChanged("Person");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Person _Person;
        partial void OnPersonChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Person value);
        partial void OnPersonChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ContactDetails in the schema.
    /// </summary>
    public partial class ContactDetails : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property EmailBag in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<string> EmailBag
        {
            get
            {
                return this._EmailBag;
            }
            set
            {
                this.OnEmailBagChanging(value);
                this._EmailBag = value;
                this.OnEmailBagChanged();
                this.OnPropertyChanged("EmailBag");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _EmailBag = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnEmailBagChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnEmailBagChanged();
        /// <summary>
        /// There are no comments for Property AlternativeNames in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<string> AlternativeNames
        {
            get
            {
                return this._AlternativeNames;
            }
            set
            {
                this.OnAlternativeNamesChanging(value);
                this._AlternativeNames = value;
                this.OnAlternativeNamesChanged();
                this.OnPropertyChanged("AlternativeNames");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _AlternativeNames = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnAlternativeNamesChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnAlternativeNamesChanged();
        /// <summary>
        /// There are no comments for Property ContactAlias in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Aliases ContactAlias
        {
            get
            {
                return this._ContactAlias;
            }
            set
            {
                this.OnContactAliasChanging(value);
                this._ContactAlias = value;
                this.OnContactAliasChanged();
                this.OnPropertyChanged("ContactAlias");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Aliases _ContactAlias;
        partial void OnContactAliasChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Aliases value);
        partial void OnContactAliasChanged();
        /// <summary>
        /// There are no comments for Property HomePhone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone HomePhone
        {
            get
            {
                return this._HomePhone;
            }
            set
            {
                this.OnHomePhoneChanging(value);
                this._HomePhone = value;
                this.OnHomePhoneChanged();
                this.OnPropertyChanged("HomePhone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone _HomePhone;
        partial void OnHomePhoneChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone value);
        partial void OnHomePhoneChanged();
        /// <summary>
        /// There are no comments for Property WorkPhone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone WorkPhone
        {
            get
            {
                return this._WorkPhone;
            }
            set
            {
                this.OnWorkPhoneChanging(value);
                this._WorkPhone = value;
                this.OnWorkPhoneChanged();
                this.OnPropertyChanged("WorkPhone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone _WorkPhone;
        partial void OnWorkPhoneChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone value);
        partial void OnWorkPhoneChanged();
        /// <summary>
        /// There are no comments for Property MobilePhoneBag in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone> MobilePhoneBag
        {
            get
            {
                return this._MobilePhoneBag;
            }
            set
            {
                this.OnMobilePhoneBagChanging(value);
                this._MobilePhoneBag = value;
                this.OnMobilePhoneBagChanged();
                this.OnPropertyChanged("MobilePhoneBag");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone> _MobilePhoneBag = new global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone>();
        partial void OnMobilePhoneBagChanging(global::System.Collections.ObjectModel.ObservableCollection<Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone> value);
        partial void OnMobilePhoneBagChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for AuditInfo in the schema.
    /// </summary>
    public partial class AuditInfo : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AuditInfo object.
        /// </summary>
        /// <param name="modifiedDate">Initial value of ModifiedDate.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static AuditInfo CreateAuditInfo(global::System.DateTimeOffset modifiedDate)
        {
            AuditInfo auditInfo = new AuditInfo();
            auditInfo.ModifiedDate = modifiedDate;
            return auditInfo;
        }
        /// <summary>
        /// There are no comments for Property ModifiedDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.DateTimeOffset ModifiedDate
        {
            get
            {
                return this._ModifiedDate;
            }
            set
            {
                this.OnModifiedDateChanging(value);
                this._ModifiedDate = value;
                this.OnModifiedDateChanged();
                this.OnPropertyChanged("ModifiedDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.DateTimeOffset _ModifiedDate;
        partial void OnModifiedDateChanging(global::System.DateTimeOffset value);
        partial void OnModifiedDateChanged();
        /// <summary>
        /// There are no comments for Property ModifiedBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string ModifiedBy
        {
            get
            {
                return this._ModifiedBy;
            }
            set
            {
                this.OnModifiedByChanging(value);
                this._ModifiedBy = value;
                this.OnModifiedByChanged();
                this.OnPropertyChanged("ModifiedBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _ModifiedBy;
        partial void OnModifiedByChanging(string value);
        partial void OnModifiedByChanged();
        /// <summary>
        /// There are no comments for Property Concurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ConcurrencyInfo Concurrency
        {
            get
            {
                return this._Concurrency;
            }
            set
            {
                this.OnConcurrencyChanging(value);
                this._Concurrency = value;
                this.OnConcurrencyChanged();
                this.OnPropertyChanged("Concurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ConcurrencyInfo _Concurrency;
        partial void OnConcurrencyChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.ConcurrencyInfo value);
        partial void OnConcurrencyChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ConcurrencyInfo in the schema.
    /// </summary>
    public partial class ConcurrencyInfo : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property Token in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Token
        {
            get
            {
                return this._Token;
            }
            set
            {
                this.OnTokenChanging(value);
                this._Token = value;
                this.OnTokenChanged();
                this.OnPropertyChanged("Token");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Token;
        partial void OnTokenChanging(string value);
        partial void OnTokenChanged();
        /// <summary>
        /// There are no comments for Property QueriedDateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Nullable<global::System.DateTimeOffset> QueriedDateTime
        {
            get
            {
                return this._QueriedDateTime;
            }
            set
            {
                this.OnQueriedDateTimeChanging(value);
                this._QueriedDateTime = value;
                this.OnQueriedDateTimeChanged();
                this.OnPropertyChanged("QueriedDateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Nullable<global::System.DateTimeOffset> _QueriedDateTime;
        partial void OnQueriedDateTimeChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnQueriedDateTimeChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Dimensions in the schema.
    /// </summary>
    public partial class Dimensions : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Dimensions object.
        /// </summary>
        /// <param name="width">Initial value of Width.</param>
        /// <param name="height">Initial value of Height.</param>
        /// <param name="depth">Initial value of Depth.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static Dimensions CreateDimensions(decimal width, decimal height, decimal depth)
        {
            Dimensions dimensions = new Dimensions();
            dimensions.Width = width;
            dimensions.Height = height;
            dimensions.Depth = depth;
            return dimensions;
        }
        /// <summary>
        /// There are no comments for Property Width in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public decimal Width
        {
            get
            {
                return this._Width;
            }
            set
            {
                this.OnWidthChanging(value);
                this._Width = value;
                this.OnWidthChanged();
                this.OnPropertyChanged("Width");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private decimal _Width;
        partial void OnWidthChanging(decimal value);
        partial void OnWidthChanged();
        /// <summary>
        /// There are no comments for Property Height in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public decimal Height
        {
            get
            {
                return this._Height;
            }
            set
            {
                this.OnHeightChanging(value);
                this._Height = value;
                this.OnHeightChanged();
                this.OnPropertyChanged("Height");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private decimal _Height;
        partial void OnHeightChanging(decimal value);
        partial void OnHeightChanged();
        /// <summary>
        /// There are no comments for Property Depth in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public decimal Depth
        {
            get
            {
                return this._Depth;
            }
            set
            {
                this.OnDepthChanging(value);
                this._Depth = value;
                this.OnDepthChanged();
                this.OnPropertyChanged("Depth");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private decimal _Depth;
        partial void OnDepthChanging(decimal value);
        partial void OnDepthChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ComplexToCategory in the schema.
    /// </summary>
    public partial class ComplexToCategory : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property Term in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Term
        {
            get
            {
                return this._Term;
            }
            set
            {
                this.OnTermChanging(value);
                this._Term = value;
                this.OnTermChanged();
                this.OnPropertyChanged("Term");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Term;
        partial void OnTermChanging(string value);
        partial void OnTermChanged();
        /// <summary>
        /// There are no comments for Property Scheme in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Scheme
        {
            get
            {
                return this._Scheme;
            }
            set
            {
                this.OnSchemeChanging(value);
                this._Scheme = value;
                this.OnSchemeChanged();
                this.OnPropertyChanged("Scheme");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Scheme;
        partial void OnSchemeChanging(string value);
        partial void OnSchemeChanged();
        /// <summary>
        /// There are no comments for Property Label in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Label
        {
            get
            {
                return this._Label;
            }
            set
            {
                this.OnLabelChanging(value);
                this._Label = value;
                this.OnLabelChanged();
                this.OnPropertyChanged("Label");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Label;
        partial void OnLabelChanging(string value);
        partial void OnLabelChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Phone in the schema.
    /// </summary>
    public partial class Phone : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property PhoneNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string PhoneNumber
        {
            get
            {
                return this._PhoneNumber;
            }
            set
            {
                this.OnPhoneNumberChanging(value);
                this._PhoneNumber = value;
                this.OnPhoneNumberChanged();
                this.OnPropertyChanged("PhoneNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _PhoneNumber;
        partial void OnPhoneNumberChanging(string value);
        partial void OnPhoneNumberChanged();
        /// <summary>
        /// There are no comments for Property Extension in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Extension
        {
            get
            {
                return this._Extension;
            }
            set
            {
                this.OnExtensionChanging(value);
                this._Extension = value;
                this.OnExtensionChanged();
                this.OnPropertyChanged("Extension");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Extension;
        partial void OnExtensionChanging(string value);
        partial void OnExtensionChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Aliases in the schema.
    /// </summary>
    public partial class Aliases : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property AlternativeNames in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<string> AlternativeNames
        {
            get
            {
                return this._AlternativeNames;
            }
            set
            {
                this.OnAlternativeNamesChanging(value);
                this._AlternativeNames = value;
                this.OnAlternativeNamesChanged();
                this.OnPropertyChanged("AlternativeNames");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _AlternativeNames = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnAlternativeNamesChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnAlternativeNamesChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for AllSpatialCollectionTypes_Simple in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("Id")]
    public partial class AllSpatialCollectionTypes_Simple : AllSpatialCollectionTypes
    {
        /// <summary>
        /// Create a new AllSpatialCollectionTypes_Simple object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static AllSpatialCollectionTypes_Simple CreateAllSpatialCollectionTypes_Simple(int ID)
        {
            AllSpatialCollectionTypes_Simple allSpatialCollectionTypes_Simple = new AllSpatialCollectionTypes_Simple();
            allSpatialCollectionTypes_Simple.Id = ID;
            return allSpatialCollectionTypes_Simple;
        }
        /// <summary>
        /// There are no comments for Property ManyGeogPoint in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeographyPoint> ManyGeogPoint
        {
            get
            {
                return this._ManyGeogPoint;
            }
            set
            {
                this.OnManyGeogPointChanging(value);
                this._ManyGeogPoint = value;
                this.OnManyGeogPointChanged();
                this.OnPropertyChanged("ManyGeogPoint");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeographyPoint> _ManyGeogPoint = new global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeographyPoint>();
        partial void OnManyGeogPointChanging(global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeographyPoint> value);
        partial void OnManyGeogPointChanged();
        /// <summary>
        /// There are no comments for Property ManyGeogLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeographyLineString> ManyGeogLine
        {
            get
            {
                return this._ManyGeogLine;
            }
            set
            {
                this.OnManyGeogLineChanging(value);
                this._ManyGeogLine = value;
                this.OnManyGeogLineChanged();
                this.OnPropertyChanged("ManyGeogLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeographyLineString> _ManyGeogLine = new global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeographyLineString>();
        partial void OnManyGeogLineChanging(global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeographyLineString> value);
        partial void OnManyGeogLineChanged();
        /// <summary>
        /// There are no comments for Property ManyGeogPolygon in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeographyPolygon> ManyGeogPolygon
        {
            get
            {
                return this._ManyGeogPolygon;
            }
            set
            {
                this.OnManyGeogPolygonChanging(value);
                this._ManyGeogPolygon = value;
                this.OnManyGeogPolygonChanged();
                this.OnPropertyChanged("ManyGeogPolygon");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeographyPolygon> _ManyGeogPolygon = new global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeographyPolygon>();
        partial void OnManyGeogPolygonChanging(global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeographyPolygon> value);
        partial void OnManyGeogPolygonChanged();
        /// <summary>
        /// There are no comments for Property ManyGeomPoint in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeometryPoint> ManyGeomPoint
        {
            get
            {
                return this._ManyGeomPoint;
            }
            set
            {
                this.OnManyGeomPointChanging(value);
                this._ManyGeomPoint = value;
                this.OnManyGeomPointChanged();
                this.OnPropertyChanged("ManyGeomPoint");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeometryPoint> _ManyGeomPoint = new global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeometryPoint>();
        partial void OnManyGeomPointChanging(global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeometryPoint> value);
        partial void OnManyGeomPointChanged();
        /// <summary>
        /// There are no comments for Property ManyGeomLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeometryLineString> ManyGeomLine
        {
            get
            {
                return this._ManyGeomLine;
            }
            set
            {
                this.OnManyGeomLineChanging(value);
                this._ManyGeomLine = value;
                this.OnManyGeomLineChanged();
                this.OnPropertyChanged("ManyGeomLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeometryLineString> _ManyGeomLine = new global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeometryLineString>();
        partial void OnManyGeomLineChanging(global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeometryLineString> value);
        partial void OnManyGeomLineChanged();
        /// <summary>
        /// There are no comments for Property ManyGeomPolygon in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeometryPolygon> ManyGeomPolygon
        {
            get
            {
                return this._ManyGeomPolygon;
            }
            set
            {
                this.OnManyGeomPolygonChanging(value);
                this._ManyGeomPolygon = value;
                this.OnManyGeomPolygonChanged();
                this.OnPropertyChanged("ManyGeomPolygon");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeometryPolygon> _ManyGeomPolygon = new global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeometryPolygon>();
        partial void OnManyGeomPolygonChanging(global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Spatial.GeometryPolygon> value);
        partial void OnManyGeomPolygonChanged();
    }
    /// <summary>
    /// There are no comments for ProductPageView in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PageViewId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("PageViewId")]
    public partial class ProductPageView : PageView
    {
        /// <summary>
        /// Create a new ProductPageView object.
        /// </summary>
        /// <param name="pageViewId">Initial value of PageViewId.</param>
        /// <param name="viewed">Initial value of Viewed.</param>
        /// <param name="timeSpentOnPage">Initial value of TimeSpentOnPage.</param>
        /// <param name="productId">Initial value of ProductId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static ProductPageView CreateProductPageView(int pageViewId, string viewed, global::System.TimeSpan timeSpentOnPage, int productId)
        {
            ProductPageView productPageView = new ProductPageView();
            productPageView.PageViewId = pageViewId;
            productPageView.Viewed = viewed;
            productPageView.TimeSpentOnPage = timeSpentOnPage;
            productPageView.ProductId = productId;
            return productPageView;
        }
        /// <summary>
        /// There are no comments for Property ProductId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int ProductId
        {
            get
            {
                return this._ProductId;
            }
            set
            {
                this.OnProductIdChanging(value);
                this._ProductId = value;
                this.OnProductIdChanged();
                this.OnPropertyChanged("ProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _ProductId;
        partial void OnProductIdChanging(int value);
        partial void OnProductIdChanged();
        /// <summary>
        /// There are no comments for Property ConcurrencyToken in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string ConcurrencyToken
        {
            get
            {
                return this._ConcurrencyToken;
            }
            set
            {
                this.OnConcurrencyTokenChanging(value);
                this._ConcurrencyToken = value;
                this.OnConcurrencyTokenChanged();
                this.OnPropertyChanged("ConcurrencyToken");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _ConcurrencyToken;
        partial void OnConcurrencyTokenChanging(string value);
        partial void OnConcurrencyTokenChanged();
    }
    /// <summary>
    /// There are no comments for BackOrderLine in the schema.
    /// </summary>
    /// <KeyProperties>
    /// OrderId
    /// ProductId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("OrderId", "ProductId")]
    public partial class BackOrderLine : OrderLine
    {
        /// <summary>
        /// Create a new BackOrderLine object.
        /// </summary>
        /// <param name="orderLineStream">Initial value of OrderLineStream.</param>
        /// <param name="orderId">Initial value of OrderId.</param>
        /// <param name="productId">Initial value of ProductId.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static BackOrderLine CreateBackOrderLine(global::Microsoft.OData.Client.DataServiceStreamLink orderLineStream, int orderId, int productId, int quantity)
        {
            BackOrderLine backOrderLine = new BackOrderLine();
            backOrderLine.OrderLineStream = orderLineStream;
            backOrderLine.OrderId = orderId;
            backOrderLine.ProductId = productId;
            backOrderLine.Quantity = quantity;
            return backOrderLine;
        }
    }
    /// <summary>
    /// There are no comments for BackOrderLine2 in the schema.
    /// </summary>
    /// <KeyProperties>
    /// OrderId
    /// ProductId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("OrderId", "ProductId")]
    public partial class BackOrderLine2 : BackOrderLine
    {
        /// <summary>
        /// Create a new BackOrderLine2 object.
        /// </summary>
        /// <param name="orderLineStream">Initial value of OrderLineStream.</param>
        /// <param name="orderId">Initial value of OrderId.</param>
        /// <param name="productId">Initial value of ProductId.</param>
        /// <param name="quantity">Initial value of Quantity.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static BackOrderLine2 CreateBackOrderLine2(global::Microsoft.OData.Client.DataServiceStreamLink orderLineStream, int orderId, int productId, int quantity)
        {
            BackOrderLine2 backOrderLine2 = new BackOrderLine2();
            backOrderLine2.OrderLineStream = orderLineStream;
            backOrderLine2.OrderId = orderId;
            backOrderLine2.ProductId = productId;
            backOrderLine2.Quantity = quantity;
            return backOrderLine2;
        }
    }
    /// <summary>
    /// There are no comments for DiscontinuedProduct in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ProductId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("ProductId")]
    public partial class DiscontinuedProduct : Product
    {
        /// <summary>
        /// Create a new DiscontinuedProduct object.
        /// </summary>
        /// <param name="picture">Initial value of Picture.</param>
        /// <param name="productId">Initial value of ProductId.</param>
        /// <param name="discontinued">Initial value of Discontinued.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static DiscontinuedProduct CreateDiscontinuedProduct(global::Microsoft.OData.Client.DataServiceStreamLink picture, int productId, global::System.DateTimeOffset discontinued)
        {
            DiscontinuedProduct discontinuedProduct = new DiscontinuedProduct();
            discontinuedProduct.Picture = picture;
            discontinuedProduct.ProductId = productId;
            discontinuedProduct.Discontinued = discontinued;
            return discontinuedProduct;
        }
        /// <summary>
        /// There are no comments for Property Discontinued in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.DateTimeOffset Discontinued
        {
            get
            {
                return this._Discontinued;
            }
            set
            {
                this.OnDiscontinuedChanging(value);
                this._Discontinued = value;
                this.OnDiscontinuedChanged();
                this.OnPropertyChanged("Discontinued");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.DateTimeOffset _Discontinued;
        partial void OnDiscontinuedChanging(global::System.DateTimeOffset value);
        partial void OnDiscontinuedChanged();
        /// <summary>
        /// There are no comments for Property ReplacementProductId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.Nullable<int> ReplacementProductId
        {
            get
            {
                return this._ReplacementProductId;
            }
            set
            {
                this.OnReplacementProductIdChanging(value);
                this._ReplacementProductId = value;
                this.OnReplacementProductIdChanged();
                this.OnPropertyChanged("ReplacementProductId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.Nullable<int> _ReplacementProductId;
        partial void OnReplacementProductIdChanging(global::System.Nullable<int> value);
        partial void OnReplacementProductIdChanged();
        /// <summary>
        /// There are no comments for Property DiscontinuedPhone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone DiscontinuedPhone
        {
            get
            {
                return this._DiscontinuedPhone;
            }
            set
            {
                this.OnDiscontinuedPhoneChanging(value);
                this._DiscontinuedPhone = value;
                this.OnDiscontinuedPhoneChanged();
                this.OnPropertyChanged("DiscontinuedPhone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone _DiscontinuedPhone;
        partial void OnDiscontinuedPhoneChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Phone value);
        partial void OnDiscontinuedPhoneChanged();
        /// <summary>
        /// There are no comments for Property ChildConcurrencyToken in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string ChildConcurrencyToken
        {
            get
            {
                return this._ChildConcurrencyToken;
            }
            set
            {
                this.OnChildConcurrencyTokenChanging(value);
                this._ChildConcurrencyToken = value;
                this.OnChildConcurrencyTokenChanged();
                this.OnPropertyChanged("ChildConcurrencyToken");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _ChildConcurrencyToken;
        partial void OnChildConcurrencyTokenChanging(string value);
        partial void OnChildConcurrencyTokenChanged();
    }
    /// <summary>
    /// There are no comments for Contractor in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("PersonId")]
    public partial class Contractor : Person
    {
        /// <summary>
        /// Create a new Contractor object.
        /// </summary>
        /// <param name="personId">Initial value of PersonId.</param>
        /// <param name="contratorCompanyId">Initial value of ContratorCompanyId.</param>
        /// <param name="billingRate">Initial value of BillingRate.</param>
        /// <param name="teamContactPersonId">Initial value of TeamContactPersonId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static Contractor CreateContractor(int personId, int contratorCompanyId, int billingRate, int teamContactPersonId)
        {
            Contractor contractor = new Contractor();
            contractor.PersonId = personId;
            contractor.ContratorCompanyId = contratorCompanyId;
            contractor.BillingRate = billingRate;
            contractor.TeamContactPersonId = teamContactPersonId;
            return contractor;
        }
        /// <summary>
        /// There are no comments for Property ContratorCompanyId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int ContratorCompanyId
        {
            get
            {
                return this._ContratorCompanyId;
            }
            set
            {
                this.OnContratorCompanyIdChanging(value);
                this._ContratorCompanyId = value;
                this.OnContratorCompanyIdChanged();
                this.OnPropertyChanged("ContratorCompanyId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _ContratorCompanyId;
        partial void OnContratorCompanyIdChanging(int value);
        partial void OnContratorCompanyIdChanged();
        /// <summary>
        /// There are no comments for Property BillingRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int BillingRate
        {
            get
            {
                return this._BillingRate;
            }
            set
            {
                this.OnBillingRateChanging(value);
                this._BillingRate = value;
                this.OnBillingRateChanged();
                this.OnPropertyChanged("BillingRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _BillingRate;
        partial void OnBillingRateChanging(int value);
        partial void OnBillingRateChanged();
        /// <summary>
        /// There are no comments for Property TeamContactPersonId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int TeamContactPersonId
        {
            get
            {
                return this._TeamContactPersonId;
            }
            set
            {
                this.OnTeamContactPersonIdChanging(value);
                this._TeamContactPersonId = value;
                this.OnTeamContactPersonIdChanged();
                this.OnPropertyChanged("TeamContactPersonId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _TeamContactPersonId;
        partial void OnTeamContactPersonIdChanging(int value);
        partial void OnTeamContactPersonIdChanged();
        /// <summary>
        /// There are no comments for Property JobDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string JobDescription
        {
            get
            {
                return this._JobDescription;
            }
            set
            {
                this.OnJobDescriptionChanging(value);
                this._JobDescription = value;
                this.OnJobDescriptionChanged();
                this.OnPropertyChanged("JobDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _JobDescription;
        partial void OnJobDescriptionChanging(string value);
        partial void OnJobDescriptionChanged();
    }
    /// <summary>
    /// There are no comments for Employee in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("PersonId")]
    public partial class Employee : Person
    {
        /// <summary>
        /// Create a new Employee object.
        /// </summary>
        /// <param name="personId">Initial value of PersonId.</param>
        /// <param name="managersPersonId">Initial value of ManagersPersonId.</param>
        /// <param name="salary">Initial value of Salary.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static Employee CreateEmployee(int personId, int managersPersonId, int salary)
        {
            Employee employee = new Employee();
            employee.PersonId = personId;
            employee.ManagersPersonId = managersPersonId;
            employee.Salary = salary;
            return employee;
        }
        /// <summary>
        /// There are no comments for Property ManagersPersonId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int ManagersPersonId
        {
            get
            {
                return this._ManagersPersonId;
            }
            set
            {
                this.OnManagersPersonIdChanging(value);
                this._ManagersPersonId = value;
                this.OnManagersPersonIdChanged();
                this.OnPropertyChanged("ManagersPersonId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _ManagersPersonId;
        partial void OnManagersPersonIdChanging(int value);
        partial void OnManagersPersonIdChanged();
        /// <summary>
        /// There are no comments for Property Salary in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int Salary
        {
            get
            {
                return this._Salary;
            }
            set
            {
                this.OnSalaryChanging(value);
                this._Salary = value;
                this.OnSalaryChanged();
                this.OnPropertyChanged("Salary");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _Salary;
        partial void OnSalaryChanging(int value);
        partial void OnSalaryChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
                this.OnPropertyChanged("Title");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Manager in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Employee Manager
        {
            get
            {
                return this._Manager;
            }
            set
            {
                this.OnManagerChanging(value);
                this._Manager = value;
                this.OnManagerChanged();
                this.OnPropertyChanged("Manager");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Employee _Manager;
        partial void OnManagerChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Employee value);
        partial void OnManagerChanged();
    }
    /// <summary>
    /// There are no comments for SpecialEmployee in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.KeyAttribute("PersonId")]
    public partial class SpecialEmployee : Employee
    {
        /// <summary>
        /// Create a new SpecialEmployee object.
        /// </summary>
        /// <param name="personId">Initial value of PersonId.</param>
        /// <param name="managersPersonId">Initial value of ManagersPersonId.</param>
        /// <param name="salary">Initial value of Salary.</param>
        /// <param name="carsVIN">Initial value of CarsVIN.</param>
        /// <param name="bonus">Initial value of Bonus.</param>
        /// <param name="isFullyVested">Initial value of IsFullyVested.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static SpecialEmployee CreateSpecialEmployee(int personId,
                    int managersPersonId,
                    int salary,
                    int carsVIN,
                    int bonus,
                    bool isFullyVested)
        {
            SpecialEmployee specialEmployee = new SpecialEmployee();
            specialEmployee.PersonId = personId;
            specialEmployee.ManagersPersonId = managersPersonId;
            specialEmployee.Salary = salary;
            specialEmployee.CarsVIN = carsVIN;
            specialEmployee.Bonus = bonus;
            specialEmployee.IsFullyVested = isFullyVested;
            return specialEmployee;
        }
        /// <summary>
        /// There are no comments for Property CarsVIN in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int CarsVIN
        {
            get
            {
                return this._CarsVIN;
            }
            set
            {
                this.OnCarsVINChanging(value);
                this._CarsVIN = value;
                this.OnCarsVINChanged();
                this.OnPropertyChanged("CarsVIN");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _CarsVIN;
        partial void OnCarsVINChanging(int value);
        partial void OnCarsVINChanged();
        /// <summary>
        /// There are no comments for Property Bonus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int Bonus
        {
            get
            {
                return this._Bonus;
            }
            set
            {
                this.OnBonusChanging(value);
                this._Bonus = value;
                this.OnBonusChanged();
                this.OnPropertyChanged("Bonus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _Bonus;
        partial void OnBonusChanging(int value);
        partial void OnBonusChanged();
        /// <summary>
        /// There are no comments for Property IsFullyVested in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public bool IsFullyVested
        {
            get
            {
                return this._IsFullyVested;
            }
            set
            {
                this.OnIsFullyVestedChanging(value);
                this._IsFullyVested = value;
                this.OnIsFullyVestedChanged();
                this.OnPropertyChanged("IsFullyVested");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private bool _IsFullyVested;
        partial void OnIsFullyVestedChanging(bool value);
        partial void OnIsFullyVestedChanged();
        /// <summary>
        /// There are no comments for Property Car in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Car Car
        {
            get
            {
                return this._Car;
            }
            set
            {
                this.OnCarChanging(value);
                this._Car = value;
                this.OnCarChanged();
                this.OnPropertyChanged("Car");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Car _Car;
        partial void OnCarChanging(Microsoft.Test.OData.Services.TestServices.AstoriaDefaultClientTypeMismatchServiceReference.Car value);
        partial void OnCarChanged();
    }
    /// <summary>
    /// There are no comments for ComplexWithAllPrimitiveTypes in the schema.
    /// </summary>
    public partial class ComplexWithAllPrimitiveTypes : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ComplexWithAllPrimitiveTypes object.
        /// </summary>
        /// <param name="boolean">Initial value of Boolean.</param>
        /// <param name="@byte">Initial value of Byte.</param>
        /// <param name="dateTimeOffset">Initial value of DateTimeOffset.</param>
        /// <param name="@decimal">Initial value of Decimal.</param>
        /// <param name="@double">Initial value of Double.</param>
        /// <param name="int16">Initial value of Int16.</param>
        /// <param name="int32">Initial value of Int32.</param>
        /// <param name="int64">Initial value of Int64.</param>
        /// <param name="sByte">Initial value of SByte.</param>
        /// <param name="single">Initial value of Single.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public static ComplexWithAllPrimitiveTypes CreateComplexWithAllPrimitiveTypes(bool boolean,
                    byte @byte,
                    global::System.DateTimeOffset dateTimeOffset,
                    decimal @decimal,
                    double @double,
                    short int16,
                    int int32,
                    long int64,
                    sbyte sByte,
                    float single)
        {
            ComplexWithAllPrimitiveTypes complexWithAllPrimitiveTypes = new ComplexWithAllPrimitiveTypes();
            complexWithAllPrimitiveTypes.Boolean = boolean;
            complexWithAllPrimitiveTypes.Byte = @byte;
            complexWithAllPrimitiveTypes.DateTimeOffset = dateTimeOffset;
            complexWithAllPrimitiveTypes.Decimal = @decimal;
            complexWithAllPrimitiveTypes.Double = @double;
            complexWithAllPrimitiveTypes.Int16 = int16;
            complexWithAllPrimitiveTypes.Int32 = int32;
            complexWithAllPrimitiveTypes.Int64 = int64;
            complexWithAllPrimitiveTypes.SByte = sByte;
            complexWithAllPrimitiveTypes.Single = single;
            return complexWithAllPrimitiveTypes;
        }
        /// <summary>
        /// There are no comments for Property Binary in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public byte[] Binary
        {
            get
            {
                return this._Binary;
            }
            set
            {
                this.OnBinaryChanging(value);
                this._Binary = value;
                this.OnBinaryChanged();
                this.OnPropertyChanged("Binary");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private byte[] _Binary;
        partial void OnBinaryChanging(byte[] value);
        partial void OnBinaryChanged();
        /// <summary>
        /// There are no comments for Property Boolean in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public bool Boolean
        {
            get
            {
                return this._Boolean;
            }
            set
            {
                this.OnBooleanChanging(value);
                this._Boolean = value;
                this.OnBooleanChanged();
                this.OnPropertyChanged("Boolean");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private bool _Boolean;
        partial void OnBooleanChanging(bool value);
        partial void OnBooleanChanged();
        /// <summary>
        /// There are no comments for Property Byte in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public byte Byte
        {
            get
            {
                return this._Byte;
            }
            set
            {
                this.OnByteChanging(value);
                this._Byte = value;
                this.OnByteChanged();
                this.OnPropertyChanged("Byte");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private byte _Byte;
        partial void OnByteChanging(byte value);
        partial void OnByteChanged();
        /// <summary>
        /// There are no comments for Property DateTimeOffset in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::System.DateTimeOffset DateTimeOffset
        {
            get
            {
                return this._DateTimeOffset;
            }
            set
            {
                this.OnDateTimeOffsetChanging(value);
                this._DateTimeOffset = value;
                this.OnDateTimeOffsetChanged();
                this.OnPropertyChanged("DateTimeOffset");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::System.DateTimeOffset _DateTimeOffset;
        partial void OnDateTimeOffsetChanging(global::System.DateTimeOffset value);
        partial void OnDateTimeOffsetChanged();
        /// <summary>
        /// There are no comments for Property Decimal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public decimal Decimal
        {
            get
            {
                return this._Decimal;
            }
            set
            {
                this.OnDecimalChanging(value);
                this._Decimal = value;
                this.OnDecimalChanged();
                this.OnPropertyChanged("Decimal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private decimal _Decimal;
        partial void OnDecimalChanging(decimal value);
        partial void OnDecimalChanged();
        /// <summary>
        /// There are no comments for Property Double in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public double Double
        {
            get
            {
                return this._Double;
            }
            set
            {
                this.OnDoubleChanging(value);
                this._Double = value;
                this.OnDoubleChanged();
                this.OnPropertyChanged("Double");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private double _Double;
        partial void OnDoubleChanging(double value);
        partial void OnDoubleChanged();
        /// <summary>
        /// There are no comments for Property Int16 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public short Int16
        {
            get
            {
                return this._Int16;
            }
            set
            {
                this.OnInt16Changing(value);
                this._Int16 = value;
                this.OnInt16Changed();
                this.OnPropertyChanged("Int16");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private short _Int16;
        partial void OnInt16Changing(short value);
        partial void OnInt16Changed();
        /// <summary>
        /// There are no comments for Property Int32 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public int Int32
        {
            get
            {
                return this._Int32;
            }
            set
            {
                this.OnInt32Changing(value);
                this._Int32 = value;
                this.OnInt32Changed();
                this.OnPropertyChanged("Int32");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private int _Int32;
        partial void OnInt32Changing(int value);
        partial void OnInt32Changed();
        /// <summary>
        /// There are no comments for Property Int64 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public long Int64
        {
            get
            {
                return this._Int64;
            }
            set
            {
                this.OnInt64Changing(value);
                this._Int64 = value;
                this.OnInt64Changed();
                this.OnPropertyChanged("Int64");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private long _Int64;
        partial void OnInt64Changing(long value);
        partial void OnInt64Changed();
        /// <summary>
        /// There are no comments for Property SByte in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public sbyte SByte
        {
            get
            {
                return this._SByte;
            }
            set
            {
                this.OnSByteChanging(value);
                this._SByte = value;
                this.OnSByteChanged();
                this.OnPropertyChanged("SByte");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private sbyte _SByte;
        partial void OnSByteChanging(sbyte value);
        partial void OnSByteChanged();
        /// <summary>
        /// There are no comments for Property String in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public string String
        {
            get
            {
                return this._String;
            }
            set
            {
                this.OnStringChanging(value);
                this._String = value;
                this.OnStringChanged();
                this.OnPropertyChanged("String");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private string _String;
        partial void OnStringChanging(string value);
        partial void OnStringChanged();
        /// <summary>
        /// There are no comments for Property Single in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public float Single
        {
            get
            {
                return this._Single;
            }
            set
            {
                this.OnSingleChanging(value);
                this._Single = value;
                this.OnSingleChanged();
                this.OnPropertyChanged("Single");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private float _Single;
        partial void OnSingleChanging(float value);
        partial void OnSingleChanged();
        /// <summary>
        /// There are no comments for Property GeographyPoint in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeographyPoint GeographyPoint
        {
            get
            {
                return this._GeographyPoint;
            }
            set
            {
                this.OnGeographyPointChanging(value);
                this._GeographyPoint = value;
                this.OnGeographyPointChanged();
                this.OnPropertyChanged("GeographyPoint");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeographyPoint _GeographyPoint;
        partial void OnGeographyPointChanging(global::Microsoft.Spatial.GeographyPoint value);
        partial void OnGeographyPointChanged();
        /// <summary>
        /// There are no comments for Property GeometryPoint in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public global::Microsoft.Spatial.GeometryPoint GeometryPoint
        {
            get
            {
                return this._GeometryPoint;
            }
            set
            {
                this.OnGeometryPointChanging(value);
                this._GeometryPoint = value;
                this.OnGeometryPointChanged();
                this.OnPropertyChanged("GeometryPoint");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        private global::Microsoft.Spatial.GeometryPoint _GeometryPoint;
        partial void OnGeometryPointChanging(global::Microsoft.Spatial.GeometryPoint value);
        partial void OnGeometryPointChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}

