using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bit.Core.Models.Data;
using Bit.Core.Models.Table;

namespace Bit.Core.OrganizationFeatures.UserInvite
{
    public interface IOrganizationUserInviteCommand
    {
        Task<OrganizationUser> InviteUserAsync(Guid organizationId, Guid? invitingUserId,
            OrganizationUserInviteData invite, string externalId);
        Task<List<OrganizationUser>> InviteUsersAsync(Guid organizationId, Guid? invitingUserId,
            IEnumerable<(OrganizationUserInviteData invite, string externalId)> invites);
        Task<IEnumerable<(OrganizationUser orgUser, string failureReason)>> ResendInvitesAsync(Guid organizationId,
            IEnumerable<Guid> organizationUsersId);
        Task ResendInviteAsync(Guid organizationId, Guid organizationUserId);
    }
}
