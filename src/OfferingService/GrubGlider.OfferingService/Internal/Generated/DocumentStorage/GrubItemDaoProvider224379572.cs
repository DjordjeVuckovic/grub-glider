// <auto-generated/>
#pragma warning disable
using GrubGlider.OfferingService.GrubItems.Types;
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertGrubItemDaoOperation224379572
    public class UpsertGrubItemDaoOperation224379572 : Marten.Internal.Operations.StorageOperation<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>
    {
        private readonly GrubGlider.OfferingService.GrubItems.Types.GrubItemDao _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertGrubItemDaoOperation224379572(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select offering_service.mt_upsert_grubitemdao(?, ?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[0].Value = document.MenuId;
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[1].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[2].Value = _document.GetType().FullName;
            parameters[3].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[3].Value = document.Id;
            setVersionParameter(parameters[4]);
        }

    }

    // END: UpsertGrubItemDaoOperation224379572
    
    
    // START: InsertGrubItemDaoOperation224379572
    public class InsertGrubItemDaoOperation224379572 : Marten.Internal.Operations.StorageOperation<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>
    {
        private readonly GrubGlider.OfferingService.GrubItems.Types.GrubItemDao _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertGrubItemDaoOperation224379572(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select offering_service.mt_insert_grubitemdao(?, ?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[0].Value = document.MenuId;
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[1].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[2].Value = _document.GetType().FullName;
            parameters[3].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[3].Value = document.Id;
            setVersionParameter(parameters[4]);
        }

    }

    // END: InsertGrubItemDaoOperation224379572
    
    
    // START: UpdateGrubItemDaoOperation224379572
    public class UpdateGrubItemDaoOperation224379572 : Marten.Internal.Operations.StorageOperation<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>
    {
        private readonly GrubGlider.OfferingService.GrubItems.Types.GrubItemDao _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateGrubItemDaoOperation224379572(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select offering_service.mt_update_grubitemdao(?, ?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[0].Value = document.MenuId;
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[1].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[2].Value = _document.GetType().FullName;
            parameters[3].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[3].Value = document.Id;
            setVersionParameter(parameters[4]);
        }

    }

    // END: UpdateGrubItemDaoOperation224379572
    
    
    // START: QueryOnlyGrubItemDaoSelector224379572
    public class QueryOnlyGrubItemDaoSelector224379572 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyGrubItemDaoSelector224379572(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public GrubGlider.OfferingService.GrubItems.Types.GrubItemDao Resolve(System.Data.Common.DbDataReader reader)
        {

            GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document;
            document = _serializer.FromJson<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document;
            document = await _serializer.FromJsonAsync<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyGrubItemDaoSelector224379572
    
    
    // START: LightweightGrubItemDaoSelector224379572
    public class LightweightGrubItemDaoSelector224379572 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>, Marten.Linq.Selectors.ISelector<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightGrubItemDaoSelector224379572(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public GrubGlider.OfferingService.GrubItems.Types.GrubItemDao Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document;
            document = _serializer.FromJson<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document;
            document = await _serializer.FromJsonAsync<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightGrubItemDaoSelector224379572
    
    
    // START: IdentityMapGrubItemDaoSelector224379572
    public class IdentityMapGrubItemDaoSelector224379572 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>, Marten.Linq.Selectors.ISelector<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapGrubItemDaoSelector224379572(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public GrubGlider.OfferingService.GrubItems.Types.GrubItemDao Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document;
            document = _serializer.FromJson<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document;
            document = await _serializer.FromJsonAsync<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapGrubItemDaoSelector224379572
    
    
    // START: DirtyTrackingGrubItemDaoSelector224379572
    public class DirtyTrackingGrubItemDaoSelector224379572 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>, Marten.Linq.Selectors.ISelector<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingGrubItemDaoSelector224379572(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public GrubGlider.OfferingService.GrubItems.Types.GrubItemDao Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document;
            document = _serializer.FromJson<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document;
            document = await _serializer.FromJsonAsync<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingGrubItemDaoSelector224379572
    
    
    // START: QueryOnlyGrubItemDaoDocumentStorage224379572
    public class QueryOnlyGrubItemDaoDocumentStorage224379572 : Marten.Internal.Storage.QueryOnlyDocumentStorage<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyGrubItemDaoDocumentStorage224379572(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateGrubItemDaoOperation224379572
            (
                document, Identity(document),
                session.Versions.ForType<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertGrubItemDaoOperation224379572
            (
                document, Identity(document),
                session.Versions.ForType<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertGrubItemDaoOperation224379572
            (
                document, Identity(document),
                session.Versions.ForType<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyGrubItemDaoSelector224379572(session, _document);
        }

    }

    // END: QueryOnlyGrubItemDaoDocumentStorage224379572
    
    
    // START: LightweightGrubItemDaoDocumentStorage224379572
    public class LightweightGrubItemDaoDocumentStorage224379572 : Marten.Internal.Storage.LightweightDocumentStorage<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightGrubItemDaoDocumentStorage224379572(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateGrubItemDaoOperation224379572
            (
                document, Identity(document),
                session.Versions.ForType<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertGrubItemDaoOperation224379572
            (
                document, Identity(document),
                session.Versions.ForType<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertGrubItemDaoOperation224379572
            (
                document, Identity(document),
                session.Versions.ForType<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightGrubItemDaoSelector224379572(session, _document);
        }

    }

    // END: LightweightGrubItemDaoDocumentStorage224379572
    
    
    // START: IdentityMapGrubItemDaoDocumentStorage224379572
    public class IdentityMapGrubItemDaoDocumentStorage224379572 : Marten.Internal.Storage.IdentityMapDocumentStorage<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapGrubItemDaoDocumentStorage224379572(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateGrubItemDaoOperation224379572
            (
                document, Identity(document),
                session.Versions.ForType<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertGrubItemDaoOperation224379572
            (
                document, Identity(document),
                session.Versions.ForType<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertGrubItemDaoOperation224379572
            (
                document, Identity(document),
                session.Versions.ForType<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapGrubItemDaoSelector224379572(session, _document);
        }

    }

    // END: IdentityMapGrubItemDaoDocumentStorage224379572
    
    
    // START: DirtyTrackingGrubItemDaoDocumentStorage224379572
    public class DirtyTrackingGrubItemDaoDocumentStorage224379572 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingGrubItemDaoDocumentStorage224379572(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateGrubItemDaoOperation224379572
            (
                document, Identity(document),
                session.Versions.ForType<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertGrubItemDaoOperation224379572
            (
                document, Identity(document),
                session.Versions.ForType<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertGrubItemDaoOperation224379572
            (
                document, Identity(document),
                session.Versions.ForType<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingGrubItemDaoSelector224379572(session, _document);
        }

    }

    // END: DirtyTrackingGrubItemDaoDocumentStorage224379572
    
    
    // START: GrubItemDaoBulkLoader224379572
    public class GrubItemDaoBulkLoader224379572 : Marten.Internal.CodeGeneration.BulkLoader<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid> _storage;

        public GrubItemDaoBulkLoader224379572(Marten.Internal.Storage.IDocumentStorage<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY offering_service.mt_doc_grubitemdao(\"menu__id\", \"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_grubitemdao_temp(\"menu__id\", \"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into offering_service.mt_doc_grubitemdao (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", \"menu__id\", \"mt_deleted\", \"mt_deleted_at\", mt_last_modified) (select mt_doc_grubitemdao_temp.\"id\", mt_doc_grubitemdao_temp.\"data\", mt_doc_grubitemdao_temp.\"mt_version\", mt_doc_grubitemdao_temp.\"mt_dotnet_type\", mt_doc_grubitemdao_temp.\"menu__id\", mt_doc_grubitemdao_temp.\"mt_deleted\", mt_doc_grubitemdao_temp.\"mt_deleted_at\", transaction_timestamp() from mt_doc_grubitemdao_temp left join offering_service.mt_doc_grubitemdao on mt_doc_grubitemdao_temp.id = offering_service.mt_doc_grubitemdao.id where offering_service.mt_doc_grubitemdao.id is null)";

        public const string OVERWRITE_SQL = "update offering_service.mt_doc_grubitemdao target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, menu__id = source.menu__id, mt_deleted = source.mt_deleted, mt_deleted_at = source.mt_deleted_at, mt_last_modified = transaction_timestamp() FROM mt_doc_grubitemdao_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_grubitemdao_temp as select * from offering_service.mt_doc_grubitemdao limit 0";


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.MenuId, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, GrubGlider.OfferingService.GrubItems.Types.GrubItemDao document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.MenuId, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }

    }

    // END: GrubItemDaoBulkLoader224379572
    
    
    // START: GrubItemDaoProvider224379572
    public class GrubItemDaoProvider224379572 : Marten.Internal.Storage.DocumentProvider<GrubGlider.OfferingService.GrubItems.Types.GrubItemDao>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public GrubItemDaoProvider224379572(Marten.Schema.DocumentMapping mapping) : base(new GrubItemDaoBulkLoader224379572(new QueryOnlyGrubItemDaoDocumentStorage224379572(mapping)), new QueryOnlyGrubItemDaoDocumentStorage224379572(mapping), new LightweightGrubItemDaoDocumentStorage224379572(mapping), new IdentityMapGrubItemDaoDocumentStorage224379572(mapping), new DirtyTrackingGrubItemDaoDocumentStorage224379572(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: GrubItemDaoProvider224379572
    
    
}
