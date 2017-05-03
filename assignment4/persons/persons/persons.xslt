<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/">
    <html>
      <body>
        <h1>people</h1>
        <table border="1">
          <tr>
            <td>
              <b>first name</b>
            </td>
            <td>
              <b>last name</b>
            </td>
            <td>
              <b>id</b>
            </td>
            <td>
              <b>password</b>
            </td>
            <td>
              <b>encryption</b>
            </td>
            <td>
              <b>work number</b>
            </td>
            <td>
              <b>cell number</b>
            </td>
            <td>
              <b>provider</b>
            </td>
            <td>
              <b>category</b>
            </td>

          </tr>
          <!--select the parent node and then the child node to iterate through the values-->
          <!--this case persons is root with person as child each child has
                multiple attributes that we will need to sort through-->
          <xsl:for-each select="persons/person">
            <tr style="font-size: 12pt; font-family: verdana">
              <td>
                <!--access each persons personal info-->
                <xsl:value-of select="name/first-name"/>
              </td>
              <td>
                <xsl:value-of select="name/last-name"/>
              </td>
              <td>
                <xsl:value-of select="credential/id"/>
              </td>
              <td>
                <xsl:value-of select="credential/password"/>
              </td>
              <td>
                <xsl:value-of select="credential/password/@encryption"/>
              </td>
              <td>
                <xsl:value-of select="phone/work"/>
              </td>
              <td>
                <xsl:value-of select="phone/cell"/>
              </td>
              <td>
                <xsl:value-of select="phone/cell/@provider"/>
              </td>
              <td>
                <xsl:value-of select="category"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
