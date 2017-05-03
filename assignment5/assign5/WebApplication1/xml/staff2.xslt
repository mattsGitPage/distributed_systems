﻿<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/">
    <html>
      <body>
        <h1>people</h1>
        <table border="1">
          <tr>
            <td>
              <b>user name</b>
            </td>
            <td>
              <b>password</b>
            </td>
            <td>
              <b>encryption</b>
            </td>
            <td>
              <b>authentication</b>
            </td>
            <td>
              <b>id</b>
            </td>
            <td>
              <b>authorization</b>
            </td>
            <td>
              <b>status</b>
            </td>

          </tr>
          <!--select the parent node and then the child node to iterate through the values-->
          <!--this case persons is root with person as child each child has
                multiple attributes that we will need to sort through-->
          <xsl:for-each select="persons/person">
            <tr style="font-size: 12pt; font-family: verdana">
              <td>
                <!--access each persons personal info-->
                <xsl:value-of select="name/user-name"/>
              </td>
              <td>
                <xsl:value-of select="credential/password"/>
              </td>
              <td>
                <xsl:value-of select="credential/password/@encryption"/>
              </td>
              <td>
                <xsl:value-of select="authentication/id"/>
              </td>
              <td>
                <xsl:value-of select="authorization/status"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
