using FarmFreshApiService.Services;
using FarmFreshApiService.Utils;

namespace FarmFreshApiService.Managers
{
    public class SecurityManager
    {
       
        #region Public Methods

        public static string CreateSecureDBConnectionString(string connectionString)
        {
            //Connection String format = "Data Source=xx.xx.xx.xx;Initial Catalog=IDTPServerDB;User ID=icpadmin;Password=EncryptedPass

            // Get all params in connection string separated by ';'
            string[] connStringValues = connectionString.Split(Constants.DatabaseUtils.SQLDB_CONNECTION_STRING_DELIMITER);

            // Get the cypher text and tag (together)
            string cipherTextAndTag = connStringValues[3].Substring(9, connStringValues[3].Length - 9);

            // Separate out cypher text and tag (separated by '||')
            string[] cipherTextTag = cipherTextAndTag.Split(Constants.VALUE_SEPARATOR);
            
            // Decrypt and get the plain text
            // Plain text = [DB User Password]
            string plainTextPassword = SecurityService.DecryptDBCreds(cipherTextTag[0], cipherTextTag[1], SecurityConstants.Email, SecurityConstants.Contact, SecurityConstants.Location);

            //connStringValues[2] = string.Concat(connStringValues[2], SecurityConstants.SECURE_DB_USERNAME);
            //connStringValues[3] = string.Concat(connStringValues[3], SecurityConstants.SECURE_DB_PASSWORD);

            // Set the DB password 
            connStringValues[3] = connStringValues[3].Substring(0, 9); // First separate out the text 'password=', then concatenate the actual pass in the below line
            connStringValues[3] = string.Concat(connStringValues[3], plainTextPassword);

            var secureConnString = string.Join(Constants.DatabaseUtils.SQLDB_CONNECTION_STRING_DELIMITER, connStringValues);

            return secureConnString;
        }
        #endregion Public Methods

        #region Private Methods

        
        #endregion Private Methods
    }
}
