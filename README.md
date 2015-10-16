## Information
The goal of this challenge is to solve a few basic problems in C# using the EntityFramework.

#### Problem 1
Create a function that counts all users filtered by their Name or Email, use the "CountUsers" function for this.

#### Problem 2
The UserInformation Model is missing, please create the model. (Models/UserInformation.cs)

#### Problem 3
Create a function that gets a user by its zipcode, use the "FindUserByZipcode" function for this.
In the case multiple users have the same zipcode, get the first user.

#### Problem 4
Multiple users should be mapped to multiple challenges, as this mapping does not exist yet, please create it using Participants Model

#### Problem 5
Create a function thats gets all users participating in a certain challenge, of which we get the challenge by the firstname of the person who created it. Please use the "ListParticipantsByCreatorFirstname" function for this.

## Database structure

#### Tables
<table>
    <tr>
        <th>Name</th>
        <th>Description</th>
    </tr>
    <tr>
        <td>users</td>
        <td>Contains login information</td>
    </tr>
    <tr>
        <td>userinformation</td>
        <td>Contains general user information</td>
    </tr>
    <tr>
        <td>challenges</td>
        <td>Contains challenge information</td>
    </tr>
    <tr>
        <td>participants</td>
        <td>Contains the user to challenge binding</td>
    </tr>
</table>

#### Table structure of 'users':
<table>
    <tr>
        <th>Field</th>
        <th>Type</th>
    </tr>
    <tr>
        <td>id</td>
        <td>integer</td>
    </tr>
    <tr>
        <td>name</td>
        <td>string</td>
    </tr>
    <tr>
        <td>password</td>
        <td>string</td>
    </tr>
    <tr>
        <td>email</td>
        <td>string</td>
    </tr>
</table>

#### Table structure of 'userinformation':
<table>
    <tr>
        <th>Field</th>
        <th>Type</th>
    </tr>
    <tr>
        <td>userid</td>
        <td>integer</td>
    </tr>
    <tr>
        <td>firstname</td>
        <td>string</td>
    </tr>
    <tr>
        <td>lastname</td>
        <td>string</td>
    </tr>
    <tr>
        <td>zipcode</td>
        <td>string</td>
    </tr>
</table>

#### Table structure of 'challenges':
<table>
    <tr>
        <th>Field</th>
        <th>Type</th>
    </tr>
    <tr>
        <td>id</td>
        <td>integer</td>
    </tr>
    <tr>
        <td>creatorid</td>
        <td>integer</td>
    </tr>
    <tr>
        <td>name</td>
        <td>string</td>
    </tr>
</table>

#### Table structure of 'participants':
<table>
    <tr>
        <th>Field</th>
        <th>Type</th>
    </tr>
    <tr>
        <td>userid</td>
        <td>integer</td>
    </tr>
    <tr>
        <td>challengeid</td>
        <td>integer</td>
    </tr>
</table>