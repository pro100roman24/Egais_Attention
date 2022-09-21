using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Egais_Attention
{
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(Result));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (Result)serializer.Deserialize(reader);
	// }

	[XmlRoot(ElementName = "lastModifyNode")]
	public class LastModifyNode
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "dateIncoming")]
	public class DateIncoming
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "documentNumber")]
	public class DocumentNumber
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "user")]
	public class User
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "modifiedInfo")]
	public class ModifiedInfo
	{

		[XmlElement(ElementName = "date")]
		public DateTime Date { get; set; }

		[XmlElement(ElementName = "user")]
		public User User { get; set; }
	}

	[XmlRoot(ElementName = "createdInfo")]
	public class CreatedInfo
	{

		[XmlElement(ElementName = "date")]
		public DateTime Date { get; set; }

		[XmlElement(ElementName = "user")]
		public User User { get; set; }
	}

	[XmlRoot(ElementName = "store")]
	public class Store
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "supplier")]
	public class Supplier
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "comment")]
	public class Comment
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "product")]
	public class Product
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "supplierProduct")]
	public class SupplierProduct
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "amountUnit")]
	public class AmountUnit
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "containerId")]
	public class ContainerId
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "incomingAmount")]
	public class IncomingAmount
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "identityId")]
	public class IdentityId
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "type")]
	public class Type
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "shortName")]
	public class ShortName
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "isRetail")]
	public class IsRetail
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "inn")]
	public class Inn
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "kpp")]
	public class Kpp
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "tsnum")]
	public class Tsnum
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "unp")]
	public class Unp
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "rnn")]
	public class Rnn
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "index")]
	public class Index
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "regionCode")]
	public class RegionCode
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "area")]
	public class Area
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "city")]
	public class City
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "place")]
	public class Place
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "street")]
	public class Street
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "house")]
	public class House
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "building")]
	public class Building
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "liter")]
	public class Liter
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "address")]
	public class Address
	{

		[XmlElement(ElementName = "country")]
		public int Country { get; set; }

		[XmlElement(ElementName = "index")]
		public Index Index { get; set; }

		[XmlElement(ElementName = "regionCode")]
		public RegionCode RegionCode { get; set; }

		[XmlElement(ElementName = "area")]
		public Area Area { get; set; }

		[XmlElement(ElementName = "city")]
		public City City { get; set; }

		[XmlElement(ElementName = "place")]
		public Place Place { get; set; }

		[XmlElement(ElementName = "street")]
		public Street Street { get; set; }

		[XmlElement(ElementName = "house")]
		public House House { get; set; }

		[XmlElement(ElementName = "building")]
		public Building Building { get; set; }

		[XmlElement(ElementName = "liter")]
		public Liter Liter { get; set; }

		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
	}

	[XmlRoot(ElementName = "producer")]
	public class Producer
	{

		[XmlElement(ElementName = "isRetail")]
		public IsRetail IsRetail { get; set; }

		[XmlElement(ElementName = "identityId")]
		public IdentityId IdentityId { get; set; }

		[XmlElement(ElementName = "egaisOrganizationType")]
		public string EgaisOrganizationType { get; set; }

		[XmlElement(ElementName = "clientRegId")]
		public double ClientRegId { get; set; }

		[XmlElement(ElementName = "fullName")]
		public string FullName { get; set; }

		[XmlElement(ElementName = "shortName")]
		public string ShortName { get; set; }

		[XmlElement(ElementName = "inn")]
		public Inn Inn { get; set; }

		[XmlElement(ElementName = "kpp")]
		public Kpp Kpp { get; set; }

		[XmlElement(ElementName = "tsnum")]
		public Tsnum Tsnum { get; set; }

		[XmlElement(ElementName = "unp")]
		public Unp Unp { get; set; }

		[XmlElement(ElementName = "rnn")]
		public Rnn Rnn { get; set; }

		[XmlElement(ElementName = "address")]
		public Address Address { get; set; }
	}

	[XmlRoot(ElementName = "importer")]
	public class Importer
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "productInfo")]
	public class ProductInfo
	{

		[XmlElement(ElementName = "identityId")]
		public IdentityId IdentityId { get; set; }

		[XmlElement(ElementName = "packed")]
		public bool Packed { get; set; }

		[XmlElement(ElementName = "type")]
		public Type Type { get; set; }

		[XmlElement(ElementName = "fullName")]
		public string FullName { get; set; }

		[XmlElement(ElementName = "shortName")]
		public ShortName ShortName { get; set; }

		[XmlElement(ElementName = "alcCode")]
		public double AlcCode { get; set; }

		[XmlElement(ElementName = "capacity")]
		public double Capacity { get; set; }

		[XmlElement(ElementName = "alcVolume")]
		public double AlcVolume { get; set; }

		[XmlElement(ElementName = "producer")]
		public Producer Producer { get; set; }

		[XmlElement(ElementName = "importer")]
		public Importer Importer { get; set; }

		[XmlElement(ElementName = "productVCode")]
		public int ProductVCode { get; set; }
	}

	[XmlRoot(ElementName = "packId")]
	public class PackId
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "boxNumber")]
	public class BoxNumber
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "i")]
	public class I
	{

		[XmlElement(ElementName = "sentErrorMessage")]
		public SentErrorMessage SentErrorMessage { get; set; }

		[XmlElement(ElementName = "dateProcessedByEgais")]
		public DateProcessedByEgais DateProcessedByEgais { get; set; }

		[XmlElement(ElementName = "sourceRarId")]
		public double SourceRarId { get; set; }

		[XmlElement(ElementName = "status")]
		public string Status { get; set; }

		[XmlElement(ElementName = "ticketReceiveData")]
		public TicketReceiveData TicketReceiveData { get; set; }

		[XmlElement(ElementName = "ticketProcessData")]
		public TicketProcessData TicketProcessData { get; set; }

		[XmlElement(ElementName = "documentRegId")]
		public DocumentRegId DocumentRegId { get; set; }

		[XmlElement(ElementName = "egaisRegister")]
		public string EgaisRegister { get; set; }

		[XmlElement(ElementName = "egaisWriteoffType")]
		public string EgaisWriteoffType { get; set; }

		[XmlElement(ElementName = "internalDocuments")]
		public object InternalDocuments { get; set; }

		[XmlElement(ElementName = "dateLastAutomaticUpdate")]
		public DateTime DateLastAutomaticUpdate { get; set; }

		[XmlElement(ElementName = "groupId")]
		public string GroupId { get; set; }

		[XmlAttribute(AttributeName = "cls")]
		public string Cls { get; set; }

		[XmlAttribute(AttributeName = "eid")]
		public string Eid { get; set; }

		[XmlText]
		public string Text { get; set; }

		[XmlElement(ElementName = "revision")]
		public int Revision { get; set; }

		[XmlElement(ElementName = "lastModifyNode")]
		public LastModifyNode LastModifyNode { get; set; }

		[XmlElement(ElementName = "dateIncoming")]
		public DateTime DateIncoming { get; set; }

		[XmlElement(ElementName = "documentNumber")]
		public int DocumentNumber { get; set; }

		[XmlElement(ElementName = "modifiedInfo")]
		public ModifiedInfo ModifiedInfo { get; set; }

		[XmlElement(ElementName = "createdInfo")]
		public CreatedInfo CreatedInfo { get; set; }

		[XmlElement(ElementName = "deleted")]
		public bool Deleted { get; set; }

		[XmlElement(ElementName = "store")]
		public Store Store { get; set; }

		[XmlElement(ElementName = "supplier")]
		public Supplier Supplier { get; set; }

		[XmlElement(ElementName = "confirmedComment")]
		public ConfirmedComment ConfirmedComment { get; set; }

		[XmlElement(ElementName = "comment")]
		public Comment Comment { get; set; }

		[XmlElement(ElementName = "items")]
		public object Items { get; set; }

		[XmlElement(ElementName = "isAutomatic")]
		public bool IsAutomatic { get; set; }

		[XmlElement(ElementName = "departmentId")]
		public string DepartmentId { get; set; }

		[XmlElement(ElementName = "replyId")]
		public string ReplyId { get; set; }

		[XmlElement(ElementName = "sentFileName")]
		public string SentFileName { get; set; }

		[XmlElement(ElementName = "versionQuery")]
		public string VersionQuery { get; set; }

		[XmlElement(ElementName = "parameters")]
		public object Parameters { get; set; }

		[XmlElement(ElementName = "aRegId")]
		public string ARegId { get; set; }
	}

	[XmlRoot(ElementName = "marks")]
	public class Marks
	{

		[XmlElement(ElementName = "i")]
		public List<I> I { get; set; }
	}

	[XmlRoot(ElementName = "marksByBox")]
	public class MarksByBox
	{

		[XmlElement(ElementName = "i")]
		public I I { get; set; }
	}

	[XmlRoot(ElementName = "marksNotConfirmed")]
	public class MarksNotConfirmed
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "exciseNumber")]
	public class ExciseNumber
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "exciseDate")]
	public class ExciseDate
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "exciseSum")]
	public class ExciseSum
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "exciseBs")]
	public class ExciseBs
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "originalClient")]
	public class OriginalClient
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "items")]
	public class Items
	{

		[XmlElement(ElementName = "i")]
		public List<I> I { get; set; }
	}

	[XmlRoot(ElementName = "replyId")]
	public class ReplyId
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "sentFileName")]
	public class SentFileName
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "sentErrorMessage")]
	public class SentErrorMessage
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "dateProcessedByEgais")]
	public class DateProcessedByEgais
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "packed")]
	public class Packed
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "car")]
	public class Car
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "transportInfo")]
	public class TransportInfo
	{

		[XmlElement(ElementName = "changeOwnership")]
		public string ChangeOwnership { get; set; }

		[XmlElement(ElementName = "type")]
		public int Type { get; set; }

		[XmlElement(ElementName = "company")]
		public string Company { get; set; }

		[XmlElement(ElementName = "car")]
		public Car Car { get; set; }

		[XmlElement(ElementName = "transportType")]
		public string TransportType { get; set; }

		[XmlElement(ElementName = "transportRegNumber")]
		public string TransportRegNumber { get; set; }

		[XmlElement(ElementName = "trailer")]
		public object Trailer { get; set; }

		[XmlElement(ElementName = "customer")]
		public string Customer { get; set; }

		[XmlElement(ElementName = "driver")]
		public string Driver { get; set; }

		[XmlElement(ElementName = "loadPoint")]
		public string LoadPoint { get; set; }

		[XmlElement(ElementName = "unloadPoint")]
		public string UnloadPoint { get; set; }

		[XmlElement(ElementName = "redirect")]
		public object Redirect { get; set; }

		[XmlElement(ElementName = "forwarder")]
		public string Forwarder { get; set; }
	}

	[XmlRoot(ElementName = "shipperInfo")]
	public class ShipperInfo
	{

		[XmlElement(ElementName = "isRetail")]
		public IsRetail IsRetail { get; set; }

		[XmlElement(ElementName = "identityId")]
		public IdentityId IdentityId { get; set; }

		[XmlElement(ElementName = "egaisOrganizationType")]
		public string EgaisOrganizationType { get; set; }

		[XmlElement(ElementName = "clientRegId")]
		public double ClientRegId { get; set; }

		[XmlElement(ElementName = "fullName")]
		public string FullName { get; set; }

		[XmlElement(ElementName = "shortName")]
		public string ShortName { get; set; }

		[XmlElement(ElementName = "inn")]
		public double Inn { get; set; }

		[XmlElement(ElementName = "kpp")]
		public int Kpp { get; set; }

		[XmlElement(ElementName = "tsnum")]
		public Tsnum Tsnum { get; set; }

		[XmlElement(ElementName = "unp")]
		public Unp Unp { get; set; }

		[XmlElement(ElementName = "rnn")]
		public Rnn Rnn { get; set; }

		[XmlElement(ElementName = "address")]
		public Address Address { get; set; }
	}

	[XmlRoot(ElementName = "shipper")]
	public class Shipper
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "recipientInfo")]
	public class RecipientInfo
	{

		[XmlElement(ElementName = "isRetail")]
		public IsRetail IsRetail { get; set; }

		[XmlElement(ElementName = "identityId")]
		public IdentityId IdentityId { get; set; }

		[XmlElement(ElementName = "egaisOrganizationType")]
		public string EgaisOrganizationType { get; set; }

		[XmlElement(ElementName = "clientRegId")]
		public double ClientRegId { get; set; }

		[XmlElement(ElementName = "fullName")]
		public string FullName { get; set; }

		[XmlElement(ElementName = "shortName")]
		public string ShortName { get; set; }

		[XmlElement(ElementName = "inn")]
		public double Inn { get; set; }

		[XmlElement(ElementName = "kpp")]
		public int Kpp { get; set; }

		[XmlElement(ElementName = "tsnum")]
		public Tsnum Tsnum { get; set; }

		[XmlElement(ElementName = "unp")]
		public Unp Unp { get; set; }

		[XmlElement(ElementName = "rnn")]
		public Rnn Rnn { get; set; }

		[XmlElement(ElementName = "address")]
		public Address Address { get; set; }
	}

	[XmlRoot(ElementName = "supplierInfo")]
	public class SupplierInfo
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "egaisConfirmData")]
	public class EgaisConfirmData
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "ticketActReceiveData")]
	public class TicketActReceiveData
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "supplierConfirmData")]
	public class SupplierConfirmData
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "ticketActProcessData")]
	public class TicketActProcessData
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "confirmedComment")]
	public class ConfirmedComment
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "operation")]
	public class Operation
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "ticketRejectData")]
	public class TicketRejectData
	{

		[XmlElement(ElementName = "status")]
		public string Status { get; set; }

		[XmlElement(ElementName = "date")]
		public DateTime Date { get; set; }

		[XmlElement(ElementName = "operation")]
		public Operation Operation { get; set; }

		[XmlElement(ElementName = "comment")]
		public string Comment { get; set; }

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "amount")]
	public class Amount
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "actualAmount")]
	public class ActualAmount
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "amountInPrimaryUnit")]
	public class AmountInPrimaryUnit
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "price")]
	public class Price
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "ticketReceiveData")]
	public class TicketReceiveData
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }

		[XmlElement(ElementName = "status")]
		public string Status { get; set; }

		[XmlElement(ElementName = "date")]
		public DateTime Date { get; set; }

		[XmlElement(ElementName = "operation")]
		public Operation Operation { get; set; }

		[XmlElement(ElementName = "comment")]
		public string Comment { get; set; }
	}

	[XmlRoot(ElementName = "ticketProcessData")]
	public class TicketProcessData
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }

		[XmlElement(ElementName = "status")]
		public string Status { get; set; }

		[XmlElement(ElementName = "date")]
		public DateTime Date { get; set; }

		[XmlElement(ElementName = "operation")]
		public string Operation { get; set; }

		[XmlElement(ElementName = "comment")]
		public string Comment { get; set; }
	}

	[XmlRoot(ElementName = "documentRegId")]
	public class DocumentRegId
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "parameters")]
	public class Parameters
	{

		[XmlElement(ElementName = "k")]
		public string K { get; set; }

		[XmlElement(ElementName = "v")]
		public double V { get; set; }
	}

	[XmlRoot(ElementName = "returnValue")]
	public class ReturnValue
	{

		[XmlElement(ElementName = "i")]
		public List<I> I { get; set; }
	}

	[XmlRoot(ElementName = "errorString")]
	public class ErrorString
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "stackTrace")]
	public class StackTrace
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "entitiesUpdate")]
	public class EntitiesUpdate
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "licenseInfo")]
	public class LicenseInfo
	{

		[XmlAttribute(AttributeName = "null")]
		public int Null { get; set; }
	}

	[XmlRoot(ElementName = "result")]
	public class Result
	{

		[XmlElement(ElementName = "returnValue")]
		public ReturnValue ReturnValue { get; set; }

		[XmlElement(ElementName = "success")]
		public bool Success { get; set; }

		[XmlElement(ElementName = "errorString")]
		public ErrorString ErrorString { get; set; }

		[XmlElement(ElementName = "resultStatus")]
		public string ResultStatus { get; set; }

		[XmlElement(ElementName = "stackTrace")]
		public StackTrace StackTrace { get; set; }

		[XmlElement(ElementName = "entitiesUpdate")]
		public EntitiesUpdate EntitiesUpdate { get; set; }

		[XmlElement(ElementName = "licenseInfo")]
		public LicenseInfo LicenseInfo { get; set; }

		[XmlElement(ElementName = "watchDogCheckResults")]
		public object WatchDogCheckResults { get; set; }
	}




}
